using System;
using System.Threading.Tasks;

namespace workoutapp.Services
{
    public interface IProgressNotificationService
    {
        Task<bool> ProgressMessageAsync(Guid id);
        Task<bool> ProgressMessagesAsync();
    }
}
