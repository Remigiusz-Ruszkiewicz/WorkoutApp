﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace workoutapp.Models
{
    public class Workout
    {
        public Workout()
        {
            Exercises = new List<Exercise>();
        }
        public DateTime Date { get; set; }
        public List<Exercise> Exercises { get; set; }
        public int Results { get; set; }

    }
}
