using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace workoutapp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class BMICalculator
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Weight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Result { get; set; }
    }
}
