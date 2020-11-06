using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace workoutapp.Models
{
    public class BMRCalculator
    {
        public bool Gender { get; set; }
        public bool Save { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
    }
}
