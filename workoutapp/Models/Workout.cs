using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workoutapp.Contracts.Requests;

namespace workoutapp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Workout
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Workout()
        {
            Exercises = new List<Exercise>();
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Exercise> Exercises { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Results { get; set; }

    }
}
