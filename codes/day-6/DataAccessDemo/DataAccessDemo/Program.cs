//SQL Server related facilities are present
using Microsoft.Data.SqlClient;

//common data access facilities are present
using System.Data;

namespace DataAccessDemo
{
    internal class Program
    {
        static void Main()
        {
            SqlConnection? connection = null;
            try
            {
                connection = new(@"server=joydip-pc\SQLEXPRESS;database=epsilondb;user id=sa;password=sqlserver2024;TrustServerCertificate=true");

                //connect to database
                connection.Open();

                //check the state
                Console.WriteLine(connection.State.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
