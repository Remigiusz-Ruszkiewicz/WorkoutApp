using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace workoutapp.Contracts
{
    /// <summary>
    /// 
    /// </summary>
    public static class ApiRoutes
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Base = "api/v1/";

        /// <summary>
        /// 
        /// </summary>
        public static class Exercise
        {
            //Exercise
            /// <summary>
            /// 
            /// </summary>
            public const string AddExercise = Base + "Workout";
            /// <summary>
            /// 
            /// </summary>
            public const string GetAllExercises = Base + "Workout";
            /// <summary>
            /// 
            /// </summary>
            public const string GetExerciseById = Base + "Workout/{id}";
            /// <summary>
            /// 
            /// </summary>
            public const string UpdateExercise = Base + "Workout/{id}";
            /// <summary>
            /// 
            /// </summary>
            public const string DeleteExercise = Base + "Workout/{id}";
        }
        /// <summary>
        /// 
        /// </summary>
        public static class Workout
        {
            //Exercise
            /// <summary>
            /// 
            /// </summary>
            public const string AddWorkout = Base + "AddWorkout";
            /// <summary>
            /// 
            /// </summary>
            public const string GetWorkoutById = Base + "GetWorkoutById/{id}";
        }
        /// <summary>
        /// 
        /// </summary>
        public static class BodyInfo
        {
            /// <summary>
            /// 
            /// </summary>
            public const string BmiResult = Base + "BMIResult";
            /// <summary>
            /// 
            /// </summary>
            public const string BmiResultALL = Base + "BMIResults";
            /// <summary>
            /// 
            /// </summary>
            public const string AddBodyMeasure = Base + "AddBodyMeasure";
            /// <summary>
            /// 
            /// </summary>
            public const string GetAllBodyMeasures = Base + "GetAllBodyMeasures";
            /// <summary>
            /// 
            /// </summary>
            public const string AddBodyFatCalculation = Base + "AddBodyFatCalc";
            /// <summary>
            /// 
            /// </summary>
            public const string GetAllBodyFatCalculations = Base + "GetBodyFatCalc";

        }
        /// <summary>
        /// 
        /// </summary>
        public static class ProgressNotification
        {
            /// <summary>
            /// 
            /// </summary>
            public const string SendMessage = Base + "ProgressSendMessage/{id}";
            /// <summary>
            /// 
            /// </summary>
            public const string SendMessages = Base + "ProgressSendMessages";
        }
        /// <summary>
        /// 
        /// </summary>
        public static class MailSender
        {
            //MailSend
            /// <summary>
            /// 
            /// </summary>
            public const string MailSend = Base + "MailSenderPost";
            /// <summary>
            /// 
            /// </summary>
            public const string MailSendFromContact = Base + "MailSenderSendFromList/{id}";
            /// <summary>
            /// 
            /// </summary>
            public const string MailSendByAccAndCont = Base + "MailSender/SendByAccount/{id}/{loginId}";
            //MailGet
            /// <summary>
            /// 
            /// </summary>
            public const string MailGet = Base + "MailSenderGet";
            /// <summary>
            /// 
            /// </summary>
            public const string MailGetByAcc = Base + "MailSenderGet/MailGetByAcc/{id}";
            //Contacts
            /// <summary>
            /// 
            /// </summary>
            public const string AddContact = Base + "MailSender/AddContact";
            /// <summary>
            /// 
            /// </summary>
            public const string GetAllContacts = Base + "MailSender/GetAllContacts";
            /// <summary>
            /// 
            /// </summary>
            public const string GetContactById = Base + "MailSender/GetContactById/{id}";
            /// <summary>
            /// 
            /// </summary>
            public const string UpdateContact = Base + "MailSender/UpdateContact/{id}";
            /// <summary>
            /// 
            /// </summary>
            public const string DeleteContact = Base + "MailSender/DeleteContact/{id}";
            //Accounts
            /// <summary>
            /// 
            /// </summary>
            public const string AddAccount = Base + "MailSender/AddAccount";
            /// <summary>
            /// 
            /// </summary>
            public const string GetAllAccounts = Base + "MailSender/GetAllAccounts";
            /// <summary>
            /// 
            /// </summary>
            public const string GetAccountById = Base + "MailSender/GetAccountById/{id}";
            /// <summary>
            /// 
            /// </summary>
            public const string UpdateAccount = Base + "MailSender/UpdateAccount/{id}";
            /// <summary>
            /// 
            /// </summary>
            public const string DeleteAccount = Base + "MailSender/DeleteAccount/{id}";
        }
    }
}
