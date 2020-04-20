using System;

namespace SoftwareArchitectureFundamentals.SOLID.ISP.Violation.Registration
{
    class ProductRegistration : IRegistration
    {
        public void Add()
        {
            // Add new data to a database
        }

        public void IsValid()
        {
            // Validate Data
        }

        /// <summary>
        /// Interface Segregation principle
        /// Clients should not be forced to depend upon interfaces that they do not use
        /// </summary>           
        public void SendEmail()
        {
            // Product has no email, what do I do now ???
            throw new NotImplementedException();
        }
    }
}
