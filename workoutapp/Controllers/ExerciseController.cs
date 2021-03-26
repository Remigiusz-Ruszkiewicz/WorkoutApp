using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using workoutapp.Contracts;
using workoutapp.Contracts.Requests;
using workoutapp.Models;
using workoutapp.Services;

namespace workoutapp.Controllers
{
    public class ExerciseController : Controller
    {
        public ExerciseController(IExerciseService exerciseService)
        {
            ExerciseService = exerciseService;
        }

        public IExerciseService ExerciseService { get; }
        [AllowAnonymous]
        [HttpPost(ApiRoutes.Exercise.AddExercise)]
        public async Task<IActionResult> AddExercise([FromBody] ExerciseRequest exerciseRequest)
        {
            var exerciseresult = await ExerciseService.AddExerciseAsync(exerciseRequest);
            return Ok(exerciseresult);
        }
        [AllowAnonymous]
        [HttpGet(ApiRoutes.Exercise.GetAllExercises)]
        public async Task<IActionResult> GetAllExercises()
        {
            var exercises = await ExerciseService.GetExercisesAsync();
            return Ok(exercises);
        }
        [AllowAnonymous]
        [HttpGet(ApiRoutes.Exercise.GetExerciseById)]
        public async Task<IActionResult> GetExerciseById([FromRoute] Guid id)
        {
            var exercise = await ExerciseService.GetExerciseByIdAsync(id);
            if (exercise == null)
            {
                return NotFound();
            }
            return Ok(exercise);
        }
        [AllowAnonymous]
        [HttpPost(ApiRoutes.Exercise.UpdateExercise)]
        public async Task<IActionResult> UpdateExercise([FromRoute]Guid id,[FromBody] Exercise exercise)
        {
            var exercisename = await ExerciseService.GetExerciseByIdAsync(id);
            if (exercisename==null)
            {
                return NotFound();
            }
            exercisename.Name = exercise.Name;
            exercisename.Category = exercise.Category;
            var exerciseresult = await ExerciseService.EditExerciseAsync(exercisename);
            return Ok(exerciseresult);
        }
        [AllowAnonymous]
        [HttpDelete(ApiRoutes.Exercise.DeleteExercise)]
        public async Task<IActionResult> DeleteExercise([FromRoute] Guid id)
        {
            var deleted = await ExerciseService.DeleteExerciseAsync(id);
            if (deleted)
                return NoContent();
            return NotFound();
        }
    }
}
