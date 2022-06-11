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
    public class ExerciseService : IExerciseService
    {
        public ExerciseService(DataContext dbcontext)
        {
            Dbcontext = dbcontext;
        }

        public DataContext Dbcontext { get; }

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

        public async Task<Exercise> EditExerciseAsync(Exercise exercise)
        {
            Dbcontext.exercises.Update(exercise);
            await Dbcontext.SaveChangesAsync();
            return exercise;
        }

        public async Task<Exercise> GetExerciseByIdAsync(Guid id)
        {
            return await Dbcontext.exercises.SingleOrDefaultAsync(x=>x.Id ==id);
        }

        public async Task<ICollection<Exercise>> GetExercisesAsync()
        {
            var result = await Dbcontext.exercises.ToListAsync();
            return result;
        }
    }
}
