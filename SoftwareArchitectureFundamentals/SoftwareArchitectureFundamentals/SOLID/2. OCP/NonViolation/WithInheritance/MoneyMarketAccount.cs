namespace SoftwareArchitectureFundamentals.SOLID.OCP.NonViolation.WithInheritance
{
    public class MoneyMarketAccount : Account
    {
        public override void Withdraw(double amount)
        {
            Balance -= amount * .99;
        }
    }
}
