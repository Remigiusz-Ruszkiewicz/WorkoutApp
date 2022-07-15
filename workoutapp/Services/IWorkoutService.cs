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
    public interface IWorkoutService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="workoutRequest"></param>
        Task<Workout> AddWorkoutAsync(WorkoutRequest workoutRequest);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        Task<Workout> GetWorkoutByIdAsync(Guid id);
    }
}
