using System;

namespace ATMSimulation
{
    /// <summary>
    /// Represents a normal savings account.
    /// Child of Account class.
    /// </summary>
    public class SavingsAccount : Account
    {
        /// <summary>
        /// Creates a new SavingsAccount class instance.
        /// </summary>
        /// <param name="accountNumber">Identifying number for the Savings Account</param>
        /// <param name="initialBalance">Balance before any changes are made to it</param>
        public SavingsAccount(int accountNumber, decimal initialBalance) : base(accountNumber, initialBalance)
        {
        }
    }
}
