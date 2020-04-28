using SoftwareArchitectureFundamentals.SOLID.DIP.Common;
using SoftwareArchitectureFundamentals.SOLID.DIP.Common.Repositories;

namespace SoftwareArchitectureFundamentals.SOLID.DIP.Violation
{
    /// <summary>
    /// The Dependency Inversion Principle (DIP) states that high level modules should not depend on low level modules;
    /// both should depend on abstractions. 
    /// Abstractions should not depend on details. Details should depend upon abstractions.
    /// </summary>
    public class CustomerService
    {
   
        public string Add(Customer customer)
        {
            if (!customer.IsValid())
                return "Invalid data";

            var repository = new CustomerRepository(); // high-level modules shouldn't depend on low-level modules
            repository.Add(customer);

            var emailService = new EmailService(); // high-level modules shouldn't depend on low-level modules
            emailService.Send("company@company.com", customer.EmailAddress, "Welcome.", "Congratulations! You are registered.");

            return "Customer successfully registered!";
        }
    }
}
