namespace SoftwareArchitectureFundamentals.SOLID.ISP.Violation.Registration
{
    public interface IRegistration
    {
        void IsValid();
        void Add();
        void SendEmail();
    }
}
