using SoftwareArchitectureFundamentals.SOLID.DIP.Common.Entities;
using SoftwareArchitectureFundamentals.SOLID.DIP.Common.Interfaces;

namespace SoftwareArchitectureFundamentals.SOLID.DIP.NonViolation
{
    public class CustomerService
    {
        private ICustomerRepository _repository;
        private IEmailService _emailService;

        public CustomerService(ICustomerRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }

        public string Add(Customer customer)
        {
            if (!customer.IsValid())
                return "Invalid data";

            _repository.Add(customer); //This depends on abstractions

            _emailService.Send("company@company.com", customer.EmailAddress, "Welcome.", "Congratulations! You are registered.");

            return "Customer successfully registered!";
        }
    }
}
