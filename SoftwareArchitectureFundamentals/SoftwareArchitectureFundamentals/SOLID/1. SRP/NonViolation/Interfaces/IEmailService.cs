namespace SoftwareArchitectureFundamentals.SOLID.SRP.NonViolation.Interfaces
{
    public interface IEmailService
    {
        void Send(string from, string to, string subject, string body);

        bool IsValid(string emailAddress);
    }
}