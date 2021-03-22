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
            public const string AddBodyFatCalculation = Base + "BodyFatCalc";
            public const string GetAllBodyFatCalculations = Base + "BodyFatCalc";

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
            public const string MailGetByAcc = Base + "MailSenderGet/{id}";
            //Contacts
            public const string AddContact = Base + "MailSender";
            public const string GetAllContacts = Base + "MailSender";
            public const string GetContactById = Base + "MailSender/{id}";
            public const string UpdateContact = Base + "MailSender/{id}";
            public const string DeleteContact = Base + "MailSender/{id}";
            //Accounts
            public const string AddAccount = Base + "MailSender/AddAccount";
            public const string GetAllAccounts = Base + "MailSender/GetAllAccounts";
            public const string GetAccountById = Base + "MailSender/GetAccountById/{id}";
            public const string UpdateAccount = Base + "MailSender/UpdateAccount/{id}";
            public const string DeleteAccount = Base + "MailSender/DeleteAccount/{id}";
        }
    }
}
