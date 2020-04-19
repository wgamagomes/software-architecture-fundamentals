﻿namespace SoftwareArchitectureFundamentals.SOLID.OCP.NonViolation.WithExtensionMethod
{
    public static class DividendAccountWithdraw 
    {      
        public static void Withdraw(this Account account, double amount)
        {
            account.Withdraw(balance => balance - amount * .98);
        }
    }
}
