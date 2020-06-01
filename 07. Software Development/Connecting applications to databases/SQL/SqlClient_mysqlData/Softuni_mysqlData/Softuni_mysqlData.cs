    using MySql.Data.MySqlClient;
using System;

namespace Softuni_mysqlData
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server = localhost; Database = Soft_Uni; user = root; password = root;";
            //mysql сървъра е localhost
            MySqlConnection connection = new MySqlConnection(connectionString);
            using (connection)
            {
                connection.Open();
                string query = "Select Count(*) from employees";
                MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
                int count = int.Parse(mySqlCommand.ExecuteScalar().ToString());        
                Console.WriteLine(count);

                query = "Select *from employees";
                mySqlCommand = new MySqlCommand(query, connection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    Console.WriteLine($"{mySqlDataReader[0]} {mySqlDataReader[1]} {mySqlDataReader[2]}");
                }
            }
        }
    }
}
