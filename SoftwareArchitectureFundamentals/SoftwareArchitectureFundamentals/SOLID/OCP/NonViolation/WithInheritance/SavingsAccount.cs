namespace SoftwareArchitectureFundamentals.SOLID.OCP.NonViolation.WithInheritance
{
    public class SavingsAccount : Account
    {
        public override void Withdraw(double amount)
        {
            Balance -= amount * .97;
        }
    }
}
