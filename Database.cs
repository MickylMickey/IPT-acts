using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


public class Database
{
    private string connectionString = "server=localhost;database=student_rec;user=root;password=;";

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    public bool Login(string username, string password)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM UserLogintb WHERE UserName = @username AND Password = @password"; 
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0; // Returns true if user exists
            }
        }
    }
}
