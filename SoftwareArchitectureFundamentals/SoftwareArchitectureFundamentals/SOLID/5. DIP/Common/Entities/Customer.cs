using SoftwareArchitectureFundamentals.SOLID.DIP.Common.Interfaces;
using System;


namespace SoftwareArchitectureFundamentals.SOLID.DIP.Common.Entities
{

    public class Customer
    {
        private IEmailService _emailService;

        public Customer(IEmailService emailService)
        {
            _emailService = emailService;
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime InsertedAt { get; set; }
        public Customer()
        {
            Id = new Guid();
        }

        public bool IsValid()
        {
            return _emailService.IsValid(EmailAddress) 
                && !string.IsNullOrWhiteSpace(FirstName) 
                && string.IsNullOrWhiteSpace(LastName);
        }
    }
}

