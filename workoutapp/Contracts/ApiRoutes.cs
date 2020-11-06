using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace workoutapp.Contracts
{
    public static class ApiRoutes
    {
        public const string Base = "api/v1/";

        public static class Exercise
        {
            //Exercise
            public const string AddExercise = Base + "Workout";
            public const string GetAllExercises = Base + "Workout";
            public const string GetExerciseById = Base + "Workout/{id}";
            public const string UpdateExercise = Base + "Workout/{id}";
            public const string DeleteExercise = Base + "Workout/{id}";
        }
        public static class BodyInfo
        {
            public const string BmiResult = Base + "BMI";
            public const string BmiResultALL = Base + "BMI";
            public const string AddBodyMeasure = Base + "BodyMeasure";
            public const string GetAllBodyMeasures = Base + "BodyMeasure";

        }
    }
}
