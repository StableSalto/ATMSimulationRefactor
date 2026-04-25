using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulation
{
    /// <summary>
    /// Class of bank customer, combines financial accounts into one class.
    /// </summary>
    public class BankCustomer
    {
        public int CustomerNumber { get; set; }
        public int Pin { get; set; }

        public CheckingAccount CheckingAccount { get; set; }
        public SavingsAccount SavingsAccount { get; set; }
        /// <summary>
        /// Creates a new instance of the BankCustomer class.
        /// </summary>
        /// <param name="customerNumber">Unique ID number for a customer.</param>
        /// <param name="pin">Unique personalized code</param>
        /// <param name="checkingAccount">Customer's Checking Account object</param>
        /// <param name="savingsAccount">Customer's Savings Account object</param>
        public BankCustomer(int customerNumber, int pin, CheckingAccount checkingAccount, SavingsAccount savingsAccount)
        {
            CustomerNumber = customerNumber;
            Pin = pin;
            CheckingAccount = checkingAccount;
            SavingsAccount = savingsAccount;

        }
    }
}
