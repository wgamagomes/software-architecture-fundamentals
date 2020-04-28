using SoftwareArchitectureFundamentals.SOLID.DIP.Common.Entities;

namespace SoftwareArchitectureFundamentals.SOLID.DIP.Common.Interfaces
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
    }
}