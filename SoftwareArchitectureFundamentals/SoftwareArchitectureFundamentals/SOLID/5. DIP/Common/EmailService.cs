
using SoftwareArchitectureFundamentals.SOLID.DIP.Common.Interfaces;
using SoftwareArchitectureFundamentals.Stubs;
using System.Text.RegularExpressions;

namespace SoftwareArchitectureFundamentals.SOLID.DIP.Common
{
    internal class EmailService: IEmailService
    {
        public void Send(string from, string to, string subject, string body)
        {
            var mailMessage = new MailMessage(from, to);

            var smtpClient = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = "Network",
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mailMessage.Subject = subject;
            mailMessage.Body = body;
            smtpClient.Send(mailMessage);
        }

        public  bool IsValid(string emailAddress)
        {
            return Regex.IsMatch(emailAddress, @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$");
        }
    }
}