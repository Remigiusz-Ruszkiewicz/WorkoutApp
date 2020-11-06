using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace workoutapp.Models
{
    public class BodyMeasure
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public int Weight { get; set; }
        public int Bicepsleft { get; set; }
        public int BicepsRight { get; set; }
        public int Chest { get; set; }
        public int Waist { get; set; }
        public int Midsection { get; set; }
        public int Hips { get; set; }
        public int ThighLeft { get; set; }
        public int ThighRight { get; set; }
        public int CalfLeft { get; set; }
        public int CalfRight { get; set; }

    }
}
