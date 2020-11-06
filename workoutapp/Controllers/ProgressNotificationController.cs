using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

    }
}
