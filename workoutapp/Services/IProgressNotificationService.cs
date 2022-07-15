using System;
using System.Threading.Tasks;

namespace workoutapp.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IProgressNotificationService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        Task<bool> ProgressMessageAsync(Guid id);
        /// <summary>
        /// 
        /// </summary>
        Task<bool> ProgressMessagesAsync();
    }
}
