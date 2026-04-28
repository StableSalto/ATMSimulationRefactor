using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace ATMSimulation
{
    /// <summary>
    /// Acts a middleman between forms and the ATM database and does all the work.
    /// Deals with connection, execution and data mapping on the SQL side.
    /// </summary>
    public class SQLHelper
    {
        private static readonly string _executablePath = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string _databasePath = Path.GetFullPath(Path.Combine(_executablePath, @"..\..\BankDatabase.mdf"));

        private static string _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={_databasePath};Integrated Security=True";
        /// <summary>
        /// Validates the login that the user implemenets and puts it against the database.
        /// </summary>
        /// <param name="customerNumber">ID given to the customer that is used for logging in.</param>
        /// <param name="pin">Customer's secret code that acts as a password for verification.</param>
        /// <returns>True if the customer exists and the information is correct, false for every other situation.</returns>
        public static bool LoginValidation(int customerNumber, int pin)
        {
            try
            {
                using (SqlConnection databaseConnection = new SqlConnection(_connectionString))
                {
                    string query = "SELECT COUNT(*) FROM BankCustomer WHERE Customer_Number=@customerNumber AND Pin=@pin";

                    SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
                    sqlCommand.Parameters.AddWithValue("@customerNumber", customerNumber);
                    sqlCommand.Parameters.AddWithValue("@pin", pin);

                    databaseConnection.Open();

                    int count = (int)sqlCommand.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Database error during login. Please try again at a later time");
                return false;
            }
        }
        /// <summary>
        /// Gets the customer data for the main form or the "ATM Machine" view, grabbing balances and whatnot.
        /// </summary>
        /// <param name="customerNumber">Specific ID given to a customer</param>
        /// <returns>An object that stores all information regarding a customer to be used by the main form.</returns>
        public static BankCustomer GetCustomerData(int customerNumber)
        {
            try
            {
                using (SqlConnection databaseConnection = new SqlConnection(_connectionString))
                {
                    string query = @"SELECT bc.Pin, bc.Checking_Account_Number, ca.Balance AS Checking_Bal,
                                bc.Savings_Account_Number, sa.Balance AS Savings_Bal
                                FROM BankCustomer bc 
                                JOIN Account ca ON bc.Checking_Account_Number = ca.Account_Number 
                                JOIN Account sa ON bc.Savings_Account_Number = sa.Account_Number 
                                WHERE bc.Customer_Number = @customerNumber";

                    SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
                    sqlCommand.Parameters.AddWithValue("@customerNumber", customerNumber);

                    databaseConnection.Open();
                    SqlDataReader databaseReader = sqlCommand.ExecuteReader();

                    if (databaseReader.Read())
                    {
                        return ReaderToBankCustomerConversion(customerNumber, databaseReader);
                    }

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not get customer data from database.");
            }
            return null;
        }
        /// <summary>
        /// Converts what the SQL Reader reads to usable data to be used by the GetCustomerData function
        /// </summary>
        private static BankCustomer ReaderToBankCustomerConversion(int customerNumber, SqlDataReader databaseReader)
        {
            int pin = (int)databaseReader["Pin"];
            int savingsAccountNumber = (int)databaseReader["Savings_Account_Number"];
            decimal savingsBalance = (decimal)databaseReader["Savings_Bal"];
            int checkingAccountNumber = (int)databaseReader["Checking_Account_Number"];
            decimal checkingBalance = (decimal)databaseReader["Checking_Bal"];

            SavingsAccount savings = new SavingsAccount(savingsAccountNumber, savingsBalance);
            CheckingAccount checkings = new CheckingAccount(checkingAccountNumber, checkingBalance, savings);

            return new BankCustomer(customerNumber, pin, checkings, savings);
        }
        /// <summary>
        /// Updates the Balance of an account holder in the database.
        /// </summary>
        /// <param name="accountNumber">Account number that needs to be updated</param>
        /// <param name="newBalance">The balance that will be put into the database</param>
        public static void UpdateAccountBalance(int accountNumber, decimal newBalance)
        {
            try
            {
                using (SqlConnection databaseConnection = new SqlConnection(_connectionString))
                {
                    string query = "UPDATE Account SET Balance = @balance WHERE Account_Number = @account";

                    SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
                    sqlCommand.Parameters.AddWithValue("@balance", newBalance);
                    sqlCommand.Parameters.AddWithValue("@account", accountNumber);

                    databaseConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not update account balance.");
                throw new Exception("Update failed.");
            }
        }
    }
}
