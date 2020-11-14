using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace workoutapp.Models
{
    public class BodyFatCalculator
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public bool Save { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }
        public double Neck { get; set; }
        public double Waist { get; set; }
        public double Hip { get; set; }  //Woman
        public double BodyFatPercentage { get; set; }
        public double FatMass { get; set; }
        public double LeanMass { get; set; }




}
}
