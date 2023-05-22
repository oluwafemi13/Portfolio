namespace Portfolio.Utility.Interface
{
    public interface IEmailSender
    {

        public Task SendEmailAsync(EmailSettings settings);
    }
}
