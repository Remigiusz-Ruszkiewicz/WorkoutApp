using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workoutapp.Contracts.Requests;
using workoutapp.Data;
using workoutapp.Models;

namespace workoutapp.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class WorkoutService : IWorkoutService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Dbcontext"></param>
        public WorkoutService(DataContext Dbcontext)
        {
            this.Dbcontext = Dbcontext;
        }

        /// <summary>
        /// 
        /// </summary>
        public DataContext Dbcontext { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="workoutRequest"></param>
        public async Task<Workout> AddWorkoutAsync(WorkoutRequest workoutRequest)
        {
            Workout workout = new();
            workout.Id = new Guid();
            workout.Date = workoutRequest.Date;
            workout.Results = workoutRequest.Results;
            workout.Exercises = workoutRequest.Exercises;
            Dbcontext.workout.Add(workout);
            await Dbcontext.SaveChangesAsync();
            var exercisetoreturn = await GetWorkoutByIdAsync(workout.Id);
            return exercisetoreturn;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public async Task<Workout> GetWorkoutByIdAsync(Guid id)
        {
            return await Dbcontext.workout.SingleOrDefaultAsync(x => x.Id == id);

        }
    }
}
