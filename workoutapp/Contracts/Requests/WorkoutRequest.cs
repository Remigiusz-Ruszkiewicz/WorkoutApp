using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workoutapp.Models;

namespace workoutapp.Contracts.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class WorkoutRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public WorkoutRequest()
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
