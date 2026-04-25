using System;
using System.Windows.Forms;

namespace ATMSimulation
{
    /// <summary>
    /// Form class for the Logging in side of the application.
    /// Forces Login before the user can access banking info.
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Executes Login Event, checks for correct login, if not then lets them retry.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_custNumber.Text, out int customerNumber) && int.TryParse(txt_custPin.Text, out int customerPin))
            {
                bool isValid = SQLHelper.LoginValidation(customerNumber, customerPin);
                if (isValid)
                {
                    BankCustomer Customer = SQLHelper.GetCustomerData(customerNumber);
                    MainForm mainForm = new MainForm(Customer);
                    mainForm.Show();
                    this.Hide();
                }
                else { MessageBox.Show("Invalid Customer Number or Pin"); }
            }
            else { MessageBox.Show("Please only use numbers"); }

        }
    }
}
