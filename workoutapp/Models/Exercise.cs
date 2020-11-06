using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace workoutapp.Models
{
    public class Exercise
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }
}
