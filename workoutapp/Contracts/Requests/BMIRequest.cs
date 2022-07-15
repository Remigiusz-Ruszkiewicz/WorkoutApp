using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace workoutapp.Contracts.Request
{
    /// <summary>
    /// 
    /// </summary>
    public class BMIRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public bool save { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int weight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int height { get; set; }
    }
}
