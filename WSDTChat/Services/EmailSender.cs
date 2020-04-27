using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace WSDTChat.Services
{
    public class EmailSender : IEmailSender
    {
        public AuthMessageSenderOptions Options { get; }
        private const string DEFAULT_NOREPLY_EMAIL = "kevin.riedl.privat@gmail.com"; // used in case no env var set

        public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor)
        {
            this.Options = optionsAccessor.Value;
        }

        public Task Execute(string apiKey, string subject, string htmlMessage, string email)
        {
            var client = new SendGridClient(apiKey);


            var from = new EmailAddress(
                Environment.GetEnvironmentVariable("NOREPLY_EMAIL") ?? DEFAULT_NOREPLY_EMAIL,
                Options.SendGridUser);
            var msg = MailHelper.CreateSingleEmail(from, new EmailAddress(email), subject, htmlMessage, htmlMessage);
            return client.SendEmailAsync(msg);
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(Options.SendGridKey, subject, htmlMessage, email);
        }
    }
}
