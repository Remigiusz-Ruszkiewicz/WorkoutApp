using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualDesk.Models;

namespace VirtualDesk.Contracts.Responses
{
    /// <summary>
    /// 
    /// </summary>
    public class SendMailResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public SendMailResponse()
        {
            ToAddresses = new List<MailSender>();
            FromAddresses = new List<MailSender>();
        }
        /// <summary>
        /// 
        /// </summary>
        public List<MailSender> ToAddresses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<MailSender> FromAddresses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Content { get; set; }
    }
}
