using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace workoutapp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class BodyFatCalculator
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
        public bool Save { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Neck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Waist { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Hip { get; set; }  //Woman
        /// <summary>
        /// 
        /// </summary>
        public double BodyFatPercentage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double FatMass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double LeanMass { get; set; }




}
}
