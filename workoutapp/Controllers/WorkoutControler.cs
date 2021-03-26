using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using workoutapp.Contracts;
using workoutapp.Contracts.Requests;
using workoutapp.Services;

namespace workoutapp.Controllers
{
    public class WorkoutControler : Controller
    {
        public WorkoutControler(IWorkoutService workoutService)
        {
            WorkoutService = workoutService;
        }

        public IWorkoutService WorkoutService { get; }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.Workout.AddWorkout)]
        public async Task<IActionResult> AddWorkout([FromBody] WorkoutRequest workoutRequest)
        {
            var exerciseresult = await WorkoutService.AddWorkoutAsync(workoutRequest);
            return Ok(exerciseresult);
        }
        [AllowAnonymous]
        [HttpGet(ApiRoutes.Workout.GetWorkoutById)]
        public async Task<IActionResult> GetWorkoutById([FromRoute] Guid id)
        {
            var exercise = await WorkoutService.GetWorkoutByIdAsync(id);
            if (exercise == null)
            {
                return NotFound();
            }
            return Ok(exercise);
        }
    }
}
