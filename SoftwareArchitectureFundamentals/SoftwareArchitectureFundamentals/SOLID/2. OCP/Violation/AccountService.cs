namespace SoftwareArchitectureFundamentals.SOLID.OCP.Violation
{
    /// <summary>
    /// The open/closed principle states "software entities (classes, modules, functions, etc.) 
    /// should be open for extension, but closed for modification"
    /// So if a new bank account will be created this class will be modified
    /// </summary>
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
