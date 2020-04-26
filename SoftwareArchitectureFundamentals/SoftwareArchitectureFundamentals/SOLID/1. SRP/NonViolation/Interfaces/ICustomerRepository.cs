using SoftwareArchitectureFundamentals.SOLID.SRP.NonViolation.Entities;

namespace SoftwareArchitectureFundamentals.SOLID.SRP.NonViolation.Interfaces
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
    }
}