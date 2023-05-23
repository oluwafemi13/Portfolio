using MailKit.Net.Smtp;
using MimeKit;
using Portfolio.Utility.Interface;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Utility
{
    public class EmailSender : IEmailSender
    {
        public EmailSender(IConfiguration config)
        {
            SendGridSecret = config.GetValue<string>("SendGrid: SecretKey");
        }

        private string SendGridSecret { get; set; }
        public Task SendEmailAsync(EmailSettings settings)
        {
            /*var emailToSend = new MimeMessage();
           
            emailToSend.From.Add(MailboxAddress.Parse(settings.Email));
            emailToSend.To.Add(MailboxAddress.Parse("sundayjabikem@gmail.com"));
            emailToSend.Subject = settings.Subject;
            emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text= settings.Body };

            
            using (var emailClient = new SmtpClient())
            {
                emailClient.Connect()
            }*/

            var client = new SendGridClient(SendGridSecret);
            var from = new EmailAddress(settings.Email, settings.Name);
            var to = new EmailAddress("sundayjabikem@gmail.com");
            var message = MailHelper.CreateSingleEmail(from, to, settings.Subject, "", settings.Body);

            return client.SendEmailAsync(message);

        }
    }
}
