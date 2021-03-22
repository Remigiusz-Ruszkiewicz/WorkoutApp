using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace workoutapp.Contracts.Request
{
    public class BMIRequest
    {
        public bool save { get; set; }
        public int weight { get; set; }
        public int height { get; set; }
    }
}
