using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualDesk.Contracts.Requests;
using VirtualDesk.Models;

namespace VirtualDesk.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMailSenderService
    {
        //MailSend
        /// <summary>
        /// 
        /// </summary>
        /// <param name="emailMessage"></param>
        public bool MailSend(EmailMessage emailMessage);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sendMailByIdRequest"></param>
        /// <param name="id"></param>
        public Task<bool> MailSendFromContactAsync(SendMailByIdRequest sendMailByIdRequest, Guid id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sendMailByIdRequest"></param>
        /// <param name="id"></param>
        /// <param name="loginId"></param>
        public Task<bool> MailSendByAccAndContAsync(SendMailByIdRequest sendMailByIdRequest, Guid id, Guid loginId);
        //MailGet
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxCount"></param>
        public List<EmailMessage> MailGet(int maxCount = 10);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="maxCount"></param>
        public Task<List<EmailMessage>> MailGetByAcc(Guid id,int maxCount = 10);
        //Contacts
        /// <summary>
        /// 
        /// </summary>
        /// <param name="emailAccountList"></param>
        Task<EmailAccountList> AddContactAsync(EmailAccountList emailAccountList);
        /// <summary>
        /// 
        /// </summary>
        Task<ICollection<EmailAccountList>> GetAllContactsAsync();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        Task<EmailAccountList> GetContactByIdAsync(Guid id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="emailAccountList"></param>
        Task<EmailAccountList> UpdateContactAsync(EmailAccountList emailAccountList);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        Task<bool> DeleteContactAsync(Guid id);
        //Accounts
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountsList"></param>
        Task<AccountsList> AddAccountAsync(AccountsList accountsList);
        /// <summary>
        /// 
        /// </summary>
        Task<ICollection<AccountsList>> GetAllAccountsAsync();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        Task<AccountsList> GetAccountByIdAsync(Guid id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountsList"></param>
        Task<AccountsList> UpdateAccountAsync(AccountsList accountsList);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        Task<bool> DeleteAccountAsync(Guid id);
        //Inne
        /// <summary>
        /// 
        /// </summary>
        public int CheckMailQuantity();
    }
}
