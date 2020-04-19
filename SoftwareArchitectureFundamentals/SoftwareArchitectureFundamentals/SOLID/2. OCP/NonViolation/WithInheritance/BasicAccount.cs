namespace SoftwareArchitectureFundamentals.SOLID.OCP.NonViolation.WithInheritance
{
    public class BasicAccount : Account
    {
        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
