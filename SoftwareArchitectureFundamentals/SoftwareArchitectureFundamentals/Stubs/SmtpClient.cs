using System;

namespace SoftwareArchitectureFundamentals.Stubs
{
    internal class SmtpClient
    {
        public int Port { get; set; }
        public object DeliveryMethod { get; set; }
        public bool UseDefaultCredentials { get; set; }
        public string Host { get; set; }

        internal void Send(MailMessage mail)
        {
            throw new NotImplementedException();
        }
    }
}