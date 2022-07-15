using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VirtualDesk.Contracts.Requests;
using VirtualDesk.Services;
using workoutapp.Contracts;
using workoutapp.Models;
using workoutapp.Services;

namespace workoutapp.Controllers
{
    /// <summary>
    /// ProgressNotificationController
    /// </summary>
    public class ProgressNotificationController : Controller
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="progressNotificationService"></param>
        public ProgressNotificationController(IProgressNotificationService progressNotificationService)
        {
            ProgressNotificationService = progressNotificationService;
        }

        /// <summary>
        /// IProgressNotificationService
        /// </summary>
        public IProgressNotificationService ProgressNotificationService { get; }
        /// <summary>
        /// Wysyłanie Maila z Progressem do osoby po id
        /// </summary>
        /// <param name="id"></param>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.ProgressNotification.SendMessage)]
        public IActionResult MailSendFromContact([FromRoute] Guid id)
        {
            var result = ProgressNotificationService.ProgressMessageAsync(id);
            return Ok(result);
        }
        /// <summary>
        /// Wysyłanie Maila z Progressem do osób z bazy
        /// </summary>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.ProgressNotification.SendMessages)]
        public IActionResult SendMessages()
        {
            var result = ProgressNotificationService.ProgressMessagesAsync();
            return Ok(result);
        }
    }
}
