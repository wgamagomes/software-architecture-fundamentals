namespace SoftwareArchitectureFundamentals.SOLID.OCP.NonViolation.WithInheritance
{
    public class AccountService
    {
        public void Withdraw(double amount, Account account)
        {
            account.Withdraw(amount);
        }
    }
}
