using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace workoutapp.Models
{
    public class BodyFatCalculator
    {
        public bool Save { get; set; }
        public bool Gender { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Neck { get; set; }
        public int Waist { get; set; }
        public int Hip { get; set; }  //Woman
        

    }
}
