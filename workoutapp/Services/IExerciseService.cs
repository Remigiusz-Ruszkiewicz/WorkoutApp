using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workoutapp.Contracts.Requests;
using workoutapp.Models;

namespace workoutapp.Services
{
    public interface IExerciseService
    {
        Task<Exercise> AddExerciseAsync(Exercise exerciseRequest);
        Task<Exercise> EditExerciseAsync(Exercise exercise);
        Task<bool> DeleteExerciseAsync(Guid id);
        Task<ICollection<Exercise>> GetExercisesAsync();
        Task<Exercise> GetExerciseByIdAsync(Guid id);

    }
}
