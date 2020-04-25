using System;

namespace SoftwareArchitectureFundamentals.SOLID.ISP.NonViolation.CoffeeMachine
{
    public class CoffeeException: Exception
    {
        public CoffeeException(string message) :
            base(message)
        {

        }
    }
}
