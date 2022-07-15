using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualDesk.Contracts.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class SendMailByIdRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public string NameFrom { get; set; }
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
