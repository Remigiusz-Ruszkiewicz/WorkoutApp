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
    /// <summary>
    /// ExerciseController
    /// </summary>
    public class ExerciseController : Controller
    {
        /// <summary>
        /// Konstruktor ExerciseController
        /// </summary>
        /// <param name="exerciseService"></param>
        public ExerciseController(IExerciseService exerciseService)
        {
            ExerciseService = exerciseService;
        }

        /// <summary>
        /// IExerciseService
        /// </summary>
        public IExerciseService ExerciseService { get; }
        /// <summary>
        /// Dodawanie ćwiczenia
        /// </summary>
        /// <param name="exerciseRequest"></param>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.Exercise.AddExercise)]
        public async Task<IActionResult> AddExercise([FromBody] Exercise exerciseRequest)
        {
            var exerciseresult = await ExerciseService.AddExerciseAsync(exerciseRequest);
            return Ok(exerciseresult);
        }
        /// <summary>
        /// Pobieranie listy ćwiczeń
        /// </summary>
        [AllowAnonymous]
        [HttpGet(ApiRoutes.Exercise.GetAllExercises)]
        public async Task<IActionResult> GetAllExercises()
        {
            var exercises = await ExerciseService.GetExercisesAsync();
            return Ok(exercises);
        }
        /// <summary>
        /// Pobieranie ćwiczenia po id
        /// </summary>
        /// <param name="id"></param>
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
        /// <summary>
        /// Aktualizacja ćwiczenia
        /// </summary>
        /// <param name="id"></param>
        /// <param name="exercise"></param>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.Exercise.UpdateExercise)]
        public async Task<IActionResult> UpdateExercise([FromRoute] Guid id, [FromBody] Exercise exercise)
        {
            var exercisename = await ExerciseService.GetExerciseByIdAsync(id);
            if (exercisename == null)
            {
                return NotFound();
            }
            exercisename.Name = exercise.Name;
            exercisename.Category = exercise.Category;
            var exerciseresult = await ExerciseService.EditExerciseAsync(exercisename);
            return Ok(exerciseresult);
        }
        /// <summary>
        /// Usuwanie ćwiczenia
        /// </summary>
        /// <param name="id"></param>
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
