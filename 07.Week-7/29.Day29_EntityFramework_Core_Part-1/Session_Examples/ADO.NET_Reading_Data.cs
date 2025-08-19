
using Microsoft.Data.SqlClient;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Server=DESKTOP-B3L5S5L\\SQLEXPRESS; Database=Apr2025Db; Integrated Security=true; TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(connStr);


            string cmdText = "SELECT * FROM Students";
            SqlCommand cmd = new SqlCommand(cmdText, con);  


            con.Open();
            SqlDataReader reader  = cmd.ExecuteReader();


            while (reader.Read())
            {
                Console.WriteLine($"{reader["StudentID"].ToString()}, {reader["Name"].ToString()}, {reader["Age"].ToString()}, {reader["Course"].ToString()} ");
            }
            

            con.Close();

            Console.ReadLine();
        }
    }
}
