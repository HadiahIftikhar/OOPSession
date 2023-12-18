using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsPractise
{
    internal class Bank
    {
        private List<Account> accounts = new List<Account>();
        private string connectionstring = "Data Source=DESKTOP-9QSB4CK\\SQLEXPRESS;Initial Catalog=BankDatabase;Integrated Security=True";

        public void AddAccounttoDB(Account acc)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring)) 
            {
                connection.Open();

                string query = "INSERT INTO Accounts(AccountNumber, AccountHolderName, Balance)"+
                    "Values (@AccountNumber, @AccountHolderName, @Balance);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountNumber", acc.AccountNumber);
                    command.Parameters.AddWithValue("@AccountHolderName", acc.AccountHolderName);
                    command.Parameters.AddWithValue("@Balance", acc.Balance);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                string Query = "Select * from Accounts;";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Account account = new Account
                            {
                                AccountNumber = Convert.ToInt32(reader["AccountNumber"]),
                                AccountHolderName = reader["AccountHolderName"].ToString(),
                                Balance = Convert.ToDecimal(reader["Balance"])
                            };
                            accounts.Add(account);
                        }
                        
                    }
                }
            }
            return accounts;
        }

        public void DeleteAccount(Account acc)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                string query = "DELETE FROM Accounts WHERE (AccountNumber = @AccountNumber)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountNumber", acc.AccountNumber);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
