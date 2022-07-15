using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workoutapp.Contracts.Requests;
using workoutapp.Models;

namespace workoutapp.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IExerciseService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exerciseRequest"></param>
        Task<Exercise> AddExerciseAsync(Exercise exerciseRequest);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exercise"></param>
        Task<Exercise> EditExerciseAsync(Exercise exercise);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        Task<bool> DeleteExerciseAsync(Guid id);
        /// <summary>
        /// 
        /// </summary>
        Task<ICollection<Exercise>> GetExercisesAsync();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        Task<Exercise> GetExerciseByIdAsync(Guid id);

    }
}
