using System;


namespace SoftwareArchitectureFundamentals.SOLID.SRP.NonViolation
{

    public class Customer
    {
        private IEmailService _emailService;

        public Customer(IEmailService emailService)
            :base()
        {
            _emailService = emailService;
        }

        public Customer()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime InsertedAt { get; set; }

        public bool IsValid()
        {
            return _emailService.IsValid(EmailAddress) 
                && !string.IsNullOrWhiteSpace(FirstName) 
                && string.IsNullOrWhiteSpace(LastName);
        }
    }
}

