using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTry
{

    internal class Auth
    {
        private readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString;
        private readonly string connectionStringClients = System.Configuration.ConfigurationManager.ConnectionStrings["DBClients"].ConnectionString;
        public bool ValidateCredentials(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM [dbo].[Table] WHERE Name = @Name AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;

                }

            }

        } //


        public bool checkCardNumber(int CardNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringClients))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM [dbo].[Client] WHERE CardNumber = @CardNumber";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                   command.Parameters.AddWithValue("@CardNumber", CardNumber);
                  

                    int count = (int)command.ExecuteScalar();

                    return count > 0;

                }

            }

        }
    }
}
