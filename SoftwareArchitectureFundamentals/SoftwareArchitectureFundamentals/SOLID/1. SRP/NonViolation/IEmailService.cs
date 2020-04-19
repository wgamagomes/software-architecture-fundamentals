namespace SoftwareArchitectureFundamentals.SOLID.SRP.NonViolation
{
    public interface IEmailService
    {
        void Send(string from, string to, string subject, string body);

        bool IsValid(string emailAddress);
    }
}