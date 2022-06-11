using MailKit.Net.Smtp;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VirtualDesk.Contracts.Requests;
using VirtualDesk.Models;
using workoutapp.Data;
using workoutapp.Models;

namespace workoutapp.Services
{
    public class ProgressNotificationService : IProgressNotificationService
    {
        public ProgressNotificationService(IEmailConfiguration emailConfiguration, DataContext dbContext)
        {
            EmailConfiguration = emailConfiguration;
            DbContext = dbContext;
        }

        public IEmailConfiguration EmailConfiguration { get; }
        public DataContext DbContext { get; }

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

                Text = text.ReadToEnd()
            };
            using (var emailClient = new SmtpClient())
            {
                emailClient.Connect(EmailConfiguration.SmtpServer, EmailConfiguration.SmtpPort, true);
                emailClient.AuthenticationMechanisms.Remove("XOAUTH2");
                emailClient.Authenticate(EmailConfiguration.SmtpUsername, EmailConfiguration.SmtpPassword);
                emailClient.Send(message);
                emailClient.Disconnect(true);
            }
            return true;
        }

        public async Task<bool> ProgressMessagesAsync()
        {
            
            StreamReader text = new("Sample.txt");
            var mail = await DbContext.emailAccountLists.ToListAsync();
            InternetAddressList list = new();
            for (int i = 0; i < mail.Count; i++)
            {
                list.Add(new MailboxAddress(mail[i].Name,mail[i].Address));
            }
            var message = new MimeMessage();
            message.To.AddRange(list);
            message.From.Add(new MailboxAddress("WorkoutApp", "remik"));
            message.Subject = "To twoje wyniki !";
            message.Body = new TextPart(TextFormat.Html)
            {

                Text = text.ReadToEnd()
            };
            using (var emailClient = new SmtpClient())
            {
                emailClient.Connect(EmailConfiguration.SmtpServer, EmailConfiguration.SmtpPort, true);
                emailClient.AuthenticationMechanisms.Remove("XOAUTH2");
                emailClient.Authenticate(EmailConfiguration.SmtpUsername, EmailConfiguration.SmtpPassword);
                emailClient.Send(message);
                emailClient.Disconnect(true);
            }

            return true;
        }
    }
}
