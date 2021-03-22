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
    public class ProgressNotificationController : Controller
    {
        public ProgressNotificationController(IProgressNotificationService progressNotificationService)
        {
            ProgressNotificationService = progressNotificationService;
        }

        public IProgressNotificationService ProgressNotificationService { get; }
        [AllowAnonymous]
        [HttpPost(ApiRoutes.ProgressNotification.SendMessage)]
        public IActionResult MailSendFromContact([FromRoute] Guid id)
        {
            var result = ProgressNotificationService.ProgressMessageAsync(id);
            return Ok(result);
        }
        [AllowAnonymous]
        [HttpPost(ApiRoutes.ProgressNotification.SendMessages)]
        public IActionResult SenMessages()
        {
            var result = ProgressNotificationService.ProgressMessagesAsync();
            return Ok(result);
        }
    }
}
