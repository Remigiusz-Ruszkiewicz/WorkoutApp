using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualDesk.Contracts.Requests;
using workoutapp.Models;

namespace workoutapp.Services
{
    public interface IProgressNotificationService
    {
        Task<bool> ProgressMessageAsync(Guid id);
        Task<bool> ProgressMessagesAsync();
    }
}
