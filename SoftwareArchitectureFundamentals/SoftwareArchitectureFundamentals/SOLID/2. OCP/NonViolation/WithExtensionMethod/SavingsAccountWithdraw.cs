namespace SoftwareArchitectureFundamentals.SOLID.OCP.NonViolation.WithExtensionMethod
{
    public static class SavingsAccountWithdraw 
    {
        public static void Withdraw(this Account account, double amount)
        {
            account.Withdraw(balance => balance - amount * .97);
        }
    }
}
