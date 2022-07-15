using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualDesk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class EmailMessage
    {
        /// <summary>
        /// 
        /// </summary>
        public EmailMessage()
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
