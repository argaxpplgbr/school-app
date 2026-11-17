using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp
{
    public class Validation
    {
        public static bool UniqueData(string table, string entity, string inputUser)
        {
            Connection conn = new Connection();

            using(MySqlConnection connection = conn.ConnectionToSql())
            {
                bool isRegistered = false;

                try
                {
                    connection.Open();
                    string query = $"SELECT {entity} FROM {table} WHERE {entity}-@inputUser";
                    using(MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("-@inputUser", inputUser);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        isRegistered = count > 0;
                        return isRegistered;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"koneksi gagal {ex.Message}");
                }
            }
            return false;
        }
    }
}
