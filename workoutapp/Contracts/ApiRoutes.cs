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
        public static class Workout
        {
            //Exercise
            public const string AddWorkout = Base + "AddWorkout";
            public const string GetWorkoutById = Base + "GetWorkoutById/{id}";
        }
        public static class BodyInfo
        {
            public const string BmiResult = Base + "BMIResult";
            public const string BmiResultALL = Base + "BMIResults";
            public const string AddBodyMeasure = Base + "AddBodyMeasure";
            public const string GetAllBodyMeasures = Base + "GetAllBodyMeasures";
            public const string AddBodyFatCalculation = Base + "AddBodyFatCalc";
            public const string GetAllBodyFatCalculations = Base + "GetBodyFatCalc";

        }
        public static class ProgressNotification
        {
            public const string SendMessage = Base + "ProgressSendMessage/{id}";
            public const string SendMessages = Base + "ProgressSendMessages";
        }
        public static class MailSender
        {
            //MailSend
            public const string MailSend = Base + "MailSenderPost";
            public const string MailSendFromContact = Base + "MailSenderSendFromList/{id}";
            public const string MailSendByAccAndCont = Base + "MailSender/SendByAccount/{id}/{loginId}";
            //MailGet
            public const string MailGet = Base + "MailSenderGet";
            public const string MailGetByAcc = Base + "MailSenderGet/MailGetByAcc/{id}";
            //Contacts
            public const string AddContact = Base + "MailSender/AddContact";
            public const string GetAllContacts = Base + "MailSender/GetAllContacts";
            public const string GetContactById = Base + "MailSender/GetContactById/{id}";
            public const string UpdateContact = Base + "MailSender/UpdateContact/{id}";
            public const string DeleteContact = Base + "MailSender/DeleteContact/{id}";
            //Accounts
            public const string AddAccount = Base + "MailSender/AddAccount";
            public const string GetAllAccounts = Base + "MailSender/GetAllAccounts";
            public const string GetAccountById = Base + "MailSender/GetAccountById/{id}";
            public const string UpdateAccount = Base + "MailSender/UpdateAccount/{id}";
            public const string DeleteAccount = Base + "MailSender/DeleteAccount/{id}";
        }
    }
}
