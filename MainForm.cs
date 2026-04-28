using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ATMSimulation
{
    /// <summary>
    /// Class for the MainForm that acts as the part after you log into an ATM.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly BankCustomer _currentCustomer;
        public MainForm(BankCustomer Customer)
        {
            InitializeComponent();
            _currentCustomer = Customer;
            lblAccountNumberDisplay.Text = "Welcome Customer Number: " + _currentCustomer.CustomerNumber.ToString();
            lblSavingsBalance.Text = _currentCustomer.SavingsAccount.Balance.ToString("C");
            lblCheckingBalance.Text = _currentCustomer.CheckingAccount.Balance.ToString("C");
        }
        /// <summary>
        /// Executes the deposit function and checks for which account to send the logic to.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(TextBoxAmount.Text, out decimal amount))
            {
                if (rbtnChecking.Checked)
                {
                    _currentCustomer.CheckingAccount.Deposit(amount);
                    SQLHelper.UpdateAccountBalance(_currentCustomer.CheckingAccount.AccountNumber, _currentCustomer.CheckingAccount.Balance);
                }
                else
                {
                    _currentCustomer.SavingsAccount.Deposit(amount);
                    SQLHelper.UpdateAccountBalance(_currentCustomer.SavingsAccount.AccountNumber, _currentCustomer.SavingsAccount.Balance);
                }
                UpdateBalance();
                JanitorFunction();
            }
            else { MessageBox.Show("Please use a valid amount"); }
        }
        /// <summary>
        /// Executes the withdraw function and checks for which account to send the logic to.
        /// </summary>
        private void ButtonWithdraw_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(TextBoxAmount.Text, out decimal amount))
            {
                bool transactionWorked = false;

                if (rbtnChecking.Checked)
                {
                    transactionWorked = _currentCustomer.CheckingAccount.Withdraw(amount);
                    SQLHelper.UpdateAccountBalance(_currentCustomer.CheckingAccount.AccountNumber, _currentCustomer.CheckingAccount.Balance);
                    SQLHelper.UpdateAccountBalance(_currentCustomer.SavingsAccount.AccountNumber, _currentCustomer.SavingsAccount.Balance);
                }
                else
                {
                    transactionWorked = _currentCustomer.SavingsAccount.Withdraw(amount);
                    SQLHelper.UpdateAccountBalance(_currentCustomer.SavingsAccount.AccountNumber, _currentCustomer.SavingsAccount.Balance);
                }
                if (transactionWorked)
                {
                    UpdateBalance();
                    JanitorFunction();
                }
            }
            else { MessageBox.Show("Please use a valid amount"); }
        }


        /// <summary>
        /// Clears text entered in the amount text and disables the deposit and withdraw buttons.
        /// </summary>
        private void JanitorFunction()
        {
            TextBoxAmount.Clear();
            ButtonDeposit.Enabled = false;
            ButtonWithdraw.Enabled = false;
        }
        /// <summary>
        /// Updates the labels of the accounts after a change is made
        /// </summary>
        private void UpdateBalance()
        {
            lblSavingsBalance.Text = _currentCustomer.SavingsAccount.Balance.ToString("C");
            lblCheckingBalance.Text = _currentCustomer.CheckingAccount.Balance.ToString("C");
        }
        /// <summary>
        /// Checks for the textbox to change then enables the deposit and withdraw buttons.
        /// </summary>
        private void TextBoxAmount_TextChanged(object sender, EventArgs e)
        {
            bool hasAmount = !string.IsNullOrWhiteSpace(TextBoxAmount.Text);
            ButtonDeposit.Enabled = hasAmount;
            ButtonWithdraw.Enabled = hasAmount;
        }
        
    }
}
