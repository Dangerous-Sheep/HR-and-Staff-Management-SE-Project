using System;
using System.Data.SqlClient;

public class ConnectionTester
{
    public static void TestConnectionString()
    {
        string connectionString = "Data Source=UMERS-LAPTOP;Initial Catalog=hrandstaff;Integrated Security=True;TrustServerCertificate=True";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection failed: " + ex.Message);
            }
        }
    }
}
