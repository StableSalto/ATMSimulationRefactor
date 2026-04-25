using System;

namespace ATMSimulation
{
    /// <summary>
    /// Represents a normal checking account.
    /// Child class of Account Class
    /// </summary>
    public class CheckingAccount : Account
    {
        public SavingsAccount LinkedSavingsBalance { get; set; }
        /// <summary>
        /// Creates a new instance of CheckingAccount class
        /// </summary>
        /// <param name="accountNumber">Unique indentifying number for the Checking Account</param>
        /// <param name="initialBalance">Balance at the beginning before any changes.</param>
        /// <param name="linkedSavingsBalance">The balanace of the savings account that is linked to this checking account.</param>
        public CheckingAccount(int accountNumber, decimal initialBalance, SavingsAccount linkedSavingsBalance) : base(accountNumber, initialBalance)
        {
            LinkedSavingsBalance = linkedSavingsBalance;
        }
        /// <summary>
        /// Function for Withdrawing money from an account.
        /// Withdraw function overrided from Account class with the addition of being able to update the SavingsAccount class.
        /// </summary>
        /// <param name="amount">Amount to be withdrawn from account.</param>
        /// <returns>True if Withdraw succeeds (either way through Checking solely or Checking and Savings) and false for every other situtaion.</returns>
        public override bool Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                decimal balanceDifference = amount - Balance;
                if (LinkedSavingsBalance != null && LinkedSavingsBalance.Balance >= balanceDifference)
                {
                    LinkedSavingsBalance.Balance -= balanceDifference;
                    Balance = 0;
                    return true;
                }

            }
            return false;
        }
    }
}
