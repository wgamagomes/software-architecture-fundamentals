namespace SoftwareArchitectureFundamentals.SOLID.OCP.NonViolation.WithInheritance
{
    public class DividendAccount : Account
    {
        public override void Withdraw(double amount)
        {
            Balance -= amount * .98;
        }
    }
}
