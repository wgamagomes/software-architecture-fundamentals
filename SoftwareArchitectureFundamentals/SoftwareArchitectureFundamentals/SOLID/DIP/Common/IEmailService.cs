namespace SoftwareArchitectureFundamentals.SOLID.DIP.Common
{
    public interface IEmailService
    {
        void Send(string from, string to, string subject, string body);
        bool IsValid(string emailAddress);
    }
}