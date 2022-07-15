using MailKit.Net.Smtp;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using MimeKit.Text;
using System;
using System.IO;
using System.Threading.Tasks;
using VirtualDesk.Models;
using workoutapp.Data;

namespace workoutapp.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class ProgressNotificationService : IProgressNotificationService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="emailConfiguration"></param>
        /// <param name="dbContext"></param>
        public ProgressNotificationService(IEmailConfiguration emailConfiguration, DataContext dbContext)
        {
            EmailConfiguration = emailConfiguration;
            DbContext = dbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        public IEmailConfiguration EmailConfiguration { get; }
        /// <summary>
        /// 
        /// </summary>
        public DataContext DbContext { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public async Task<bool> ProgressMessageAsync(Guid id)
        {
            StreamReader text = new("Sample.txt");
            var mail = await DbContext.emailAccountLists.SingleOrDefaultAsync(x => x.Id == id);
            var message = new MimeMessage();
            message.To.Add(new MailboxAddress(mail.Name, mail.Address));
            message.From.Add(new MailboxAddress("WorkoutApp", mail.Address));
            message.Subject = "To twoje wyniki !";
            message.Body = new TextPart(TextFormat.Html)
            {

                Text = await text.ReadToEndAsync()
            };
            using (var emailClient = new SmtpClient())
            {
                emailClient.Connect(EmailConfiguration.SmtpServer, EmailConfiguration.SmtpPort, false);
                emailClient.AuthenticationMechanisms.Remove("XOAUTH2");
                emailClient.Authenticate(EmailConfiguration.SmtpUsername, EmailConfiguration.SmtpPassword);
                emailClient.Send(message);
                emailClient.Disconnect(true);
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        public async Task<bool> ProgressMessagesAsync()
        {

            StreamReader text = new("Sample.txt");
            var mail = await DbContext.emailAccountLists.ToListAsync();
            InternetAddressList list = new();
            for (int i = 0; i < mail.Count; i++)
            {
                list.Add(new MailboxAddress(mail[i].Name, mail[i].Address));
            }
            var message = new MimeMessage();
            message.To.AddRange(list);
            message.From.Add(new MailboxAddress("WorkoutApp", "remikr40000@gmail.com"));
            message.Subject = "To twoje wyniki !";
            message.Body = new TextPart(TextFormat.Html)
            {

                Text = await text.ReadToEndAsync()
            };
            using (var emailClient = new SmtpClient())
            {
                emailClient.Connect(EmailConfiguration.SmtpServer, EmailConfiguration.SmtpPort, false);
                emailClient.AuthenticationMechanisms.Remove("XOAUTH2");
                emailClient.Authenticate(EmailConfiguration.SmtpUsername, EmailConfiguration.SmtpPassword);
                emailClient.Send(message);
                emailClient.Disconnect(true);
            }

            return true;
        }
    }
}
