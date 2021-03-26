using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workoutapp.Models;

namespace workoutapp.Contracts.Requests
{
    public class WorkoutRequest
    {
        public WorkoutRequest()
        {
            Exercises = new List<ExerciseRequest>();
        }
        public DateTime Date { get; set; }
        public List<ExerciseRequest> Exercises { get; set; }
        public int Results { get; set; }
    }
}
