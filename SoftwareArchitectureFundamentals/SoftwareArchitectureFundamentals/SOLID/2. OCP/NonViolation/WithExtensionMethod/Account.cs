using System;

namespace SoftwareArchitectureFundamentals.SOLID.OCP.NonViolation.WithExtensionMethod
{
    public class Account
    {
        private double _balance;
        public string Owner { get; set; }
        public void Withdraw(Func<double, double> withdraw)
        {
            _balance = withdraw(_balance);
        }
    }
}
