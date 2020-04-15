namespace SoftwareArchitectureFundamentals.SOLID.OCP.NonViolation.WithInheritance
{
    public abstract class Account
    {        
        protected double Balance { get; set; }
        public string Owner { get; set; }
        public abstract void Withdraw(double amount);
    }
}
