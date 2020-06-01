using MySql.Data.MySqlClient;
using System;

namespace Soft_uni_Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server = localhost; Database = Soft_Uni; user = root; password = root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            using (connection)
            {
                connection.Open();
                int salary = int.Parse(Console.ReadLine());
                string query = $"Select First_Name, Last_Name, Salary from Employees where Salary >= {@salary} order by Salary";
                MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
                mySqlCommand.Parameters.AddWithValue("@salary", salary);
                //ограничава escape-ващи символи и не позволява на потребителя да въведе нещо различно от salary
                //предпазва базата данни
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine($"{reader[0]} {reader[1]} - {reader[2]}");
                }
                reader.Close();
            }
        }
    }
}
