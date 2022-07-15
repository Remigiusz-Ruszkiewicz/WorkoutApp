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
    public class ExerciseService : IExerciseService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbcontext"></param>
        public ExerciseService(DataContext dbcontext)
        {
            Dbcontext = dbcontext;
        }

        /// <summary>
        /// 
        /// </summary>
        public DataContext Dbcontext { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exerciseRequest"></param>
        public async Task<Exercise> AddExerciseAsync(Exercise exerciseRequest)
        {
            Exercise ex = new();
            ex.Category =  exerciseRequest.Category;
            ex.Name = exerciseRequest.Name;
            ex.Id = Guid.NewGuid();
            Dbcontext.exercises.Add(ex);
            await Dbcontext.SaveChangesAsync();
            var exercisetoreturn = await GetExerciseByIdAsync(ex.Id);
            return exercisetoreturn;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public async Task<bool> DeleteExerciseAsync(Guid id)
        {
            var item = await Dbcontext.exercises.SingleOrDefaultAsync(x => x.Id == id);
            if (item == null)
            {
                return false;
            }
            Dbcontext.exercises.Remove(item);
            await Dbcontext.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exercise"></param>
        public async Task<Exercise> EditExerciseAsync(Exercise exercise)
        {
            Dbcontext.exercises.Update(exercise);
            await Dbcontext.SaveChangesAsync();
            return exercise;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public async Task<Exercise> GetExerciseByIdAsync(Guid id)
        {
            return await Dbcontext.exercises.SingleOrDefaultAsync(x=>x.Id ==id);
        }

        /// <summary>
        /// 
        /// </summary>
        public async Task<ICollection<Exercise>> GetExercisesAsync()
        {
            var result = await Dbcontext.exercises.ToListAsync();
            return result;
        }
    }
}
