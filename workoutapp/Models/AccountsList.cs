using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualDesk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountsList
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Pass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string EmailAdress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SmtpServer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SmtpPort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PopServer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int PopPort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsPrivate { get; set; }
    }
}
