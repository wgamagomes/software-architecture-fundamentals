using System;

namespace SoftwareArchitectureFundamentals.SOLID.ISP.Violation.CoffeeMachine
{
    public class CoffeeException: Exception
    {
        public CoffeeException(string message) :
            base(message)
        {

        }
    }
}
