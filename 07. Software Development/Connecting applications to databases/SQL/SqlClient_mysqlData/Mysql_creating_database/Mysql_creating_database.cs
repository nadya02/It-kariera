using MySql.Data.MySqlClient;
using System;

namespace Mysql_creating_database
{
    class Program
    {
        static void Main(string[] args)
        {
            string dbName = "DemoTest";// = Console.ReadLine();
            CreateDB(dbName);

            string tableName = "Employees"; // = Console.ReadLine();
            CreateTable(dbName, tableName);

            string[] person = { "AAA", "BBB" }; // = Console.ReadLine().Split();
            string firstName = person[0];
            string lastName = person[1];
            Insert(dbName, tableName, firstName, lastName);

        }
        private static void CreateDB(string name)
        {
            string connectionString = "Server = localhost; ; user = root; password = root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            using (connection)
            {
                connection.Open();
                string query = $"create database {name}";
                MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
                mySqlCommand.ExecuteNonQuery();
            }
        }
        private static void CreateTable(string dbName, string tableName)
        {
            string connectionString = $"Server = localhost; Database = {dbName}; user = root; password = root";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $@"CREATE TABLE {tableName}
                                (
                                    id INT(10) PRIMARY KEY AUTO_INCREMENT,
                                    FirstName VARCHAR(50) NOT NULL,
                                    LastName VARCHAR(50) NOT null
                                 )";
                MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
                mySqlCommand.ExecuteNonQuery();

            }
        }
        private static void Insert(string dbName, string tableName, string firstName, string lastName)
        {
            string connectionString = $"Server = localhost; Database = {dbName}; user = root; password = root";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"insert into {tableName} (FirstName, LastName) values ('{firstName}', '{lastName}')";
                MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
                mySqlCommand.ExecuteNonQuery();
            }
        }
    }
}
