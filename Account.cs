using System.Windows.Forms;
using System;

namespace ATMSimulation
{
    /// <summary>
    /// Represents a normal account.
    /// Parent class of an account, used by the children SavingsAccount and CheckingAccount.
    /// </summary>
    public class Account
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        /// <summary>
        /// Creates a new Account class instance.
        /// </summary>
        /// <param name="accountNumber">Identifying number for an account.</param>
        /// <param name="initialBalance">Starting balance.</param>
        public Account(int accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
        /// <summary>
        /// Deposit's money into account.
        /// </summary>
        /// <param name="Amount">Amount of money being deposited.</param>
        public void Deposit(decimal Amount)
        {
            Balance += Amount;
        }
        /// <summary>
        /// Withdraw's money from an account.
        /// </summary>
        /// <param name="Amount">Amount of money being withdrawn.</param>
        /// <returns>True if withdrawal works, false if not</returns>
        public virtual bool Withdraw(decimal Amount)
        {
            if (Amount > 0 && Balance >= Amount)
            {
                Balance -= Amount;
                return true;
            }
            MessageBox.Show("You cannot withdraw that amount of money! (Negative Number or not enough Money)");
            return false;
        }
    }
}
