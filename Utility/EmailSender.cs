using MailKit.Net.Smtp;
using MimeKit;
using Portfolio.Utility.Interface;

namespace Portfolio.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(EmailSettings settings)
        {
            var emailToSend = new MimeMessage();
           
            emailToSend.From.Add(MailboxAddress.Parse(settings.Email));
            emailToSend.To.Add(MailboxAddress.Parse("sundayjabikem@gmail.com"));
            emailToSend.Subject = settings.Subject;
            emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text= settings.Body };

            
            using (var emailClient = new SmtpClient())
            {
                emailClient.Connect()
            }

        }
    }
}
