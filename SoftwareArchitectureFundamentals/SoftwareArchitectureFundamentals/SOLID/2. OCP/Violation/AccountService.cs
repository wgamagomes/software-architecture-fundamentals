namespace SoftwareArchitectureFundamentals.SOLID.OCP.Violation
{
    public class AccountService
    {
        public void Withdraw(double amount, Account account)
        {

            if (account.Type == AccountType.Basic)
            {
                account.Balance -= amount;
            }

            else if (account.Type == AccountType.Dividend)
            {
                account.Balance -= amount * .98;
            }

            else if (account.Type == AccountType.Savings)
            {
                account.Balance -= amount * .97;
            }

            else if (account.Type == AccountType.MoneyMarket)
            {
                account.Balance -= amount * .99;
            }
        }
    }


}
