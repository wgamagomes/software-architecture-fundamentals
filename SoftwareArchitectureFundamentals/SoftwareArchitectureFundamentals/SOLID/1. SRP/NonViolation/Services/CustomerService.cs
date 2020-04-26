using SoftwareArchitectureFundamentals.SOLID.SRP.NonViolation.Entities;
using SoftwareArchitectureFundamentals.SOLID.SRP.NonViolation.Interfaces;

namespace SoftwareArchitectureFundamentals.SOLID.SRP.NonViolation.Services
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

            _repository.Add(customer);

            _emailService.Send("company@company.com", customer.EmailAddress, "Welcome.", "Congratulations! You are registered.");

            return "Customer successfully registered!";
        }
    }
}
