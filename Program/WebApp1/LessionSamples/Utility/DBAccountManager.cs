using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LessionSamples.Utility
{
    public class DBAccountManager
    {
        public static DataTable GetUserAccount(string account)
        {
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLession; Integrated Security=true";

            string queryString =
                $@" SELECT * FROM UserAccount
                    WHERE Account = @account ;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@account", account);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();

                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }
    }
}