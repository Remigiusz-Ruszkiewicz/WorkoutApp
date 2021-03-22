using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace workoutapp.Models
{
    public class BMICalculator
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public double Result { get; set; }
    }
}
