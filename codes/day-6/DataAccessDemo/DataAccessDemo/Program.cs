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
            SqlCommand? command = null;
            SqlDataReader? reader = null;

            string query = "select product_id as ID, product_name as NAME, product_price as PRICE, product_description as DESCRIPTION from products";
            try
            {
                connection = new(@"server=joydip-pc\SQLEXPRESS;database=epsilondb;user id=sa;password=sqlserver2024;TrustServerCertificate=true");

                //command object is having the connectio information
                //command = connection.CreateCommand();
                //command.CommandText = query;

                //command object does not have the connectio information
                command = new();
                command.Connection = connection;
                command.CommandText = query;

                //connect to database
                connection.Open();

                //check the state
                //Console.WriteLine(connection.State.ToString());
                if (connection != null && connection.State == ConnectionState.Open && command != null && command.CommandText != string.Empty && command.CommandText != null)
                {
                    reader = command.ExecuteReader();
                    if (reader != null && reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //for (int i = 0; i < reader.FieldCount; i++)
                            //{
                            //    Console.Write(reader[i]?.ToString() + "\t");
                            //}
                            Console.Write($"{reader.GetValue("ID")?.ToString()}\t{reader.GetValue("NAME")?.ToString()}\t {reader.GetValue("PRICE")?.ToString()}\t {reader.GetValue("DESCRIPTION")?.ToString()}");
                            
                            Console.WriteLine("\n");
                        }
                        //close the reader, as it consumes/blocks the active connection
                        reader.Close();
                    }
                }
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
