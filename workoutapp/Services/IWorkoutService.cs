using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workoutapp.Contracts.Requests;
using workoutapp.Models;

namespace workoutapp.Services
{
    public interface IWorkoutService
    {
        Task<Workout> AddWorkoutAsync(WorkoutRequest workoutRequest);
        Task<Workout> GetWorkoutByIdAsync(Guid id);
    }
}
