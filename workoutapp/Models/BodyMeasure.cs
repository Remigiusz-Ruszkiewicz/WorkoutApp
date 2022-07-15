using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace workoutapp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class BodyMeasure
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
        public int Bicepsleft { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int BicepsRight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Chest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Waist { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Midsection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Hips { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ThighLeft { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ThighRight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CalfLeft { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CalfRight { get; set; }

    }
}
