using System;
using System.Data.SqlClient;

namespace NonSqlInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATE DATABASE Test
            //USE Test

            //CREATE TABLE Users(
            //Id INT PRIMARY KEY IDENTITY,
            //Username VARCHAR(20) NOT NULL,
            //PasswordHash NVARCHAR(MAX) NOT NULL
            //)

            //CREATE TABLE Test(
            //Id INT PRIMARY KEY IDENTITY,
            //Username VARCHAR(20) NOT NULL,
            //)

            //INSERT INTO Users
            //VALUES('peter', 'qwerty123')

            //SELECT* FROM Users

            //site for sql injection https://sqlzoo.net/hack/


            bool normalLogin =
   IsPasswordValid("peter", "qwerty123"); // true

            Console.WriteLine(normalLogin);

            bool sqlInjectedLogin =
              IsPasswordValid(" ' or 1=1 --", "qwerty123"); // true

            Console.WriteLine(sqlInjectedLogin);

            bool sqlInjectedLogin2 =
              IsPasswordValid(" ' or 1=1 --", " ' or 1=1 --");

            Console.WriteLine(sqlInjectedLogin2);

            bool evilHackerCreatesNewUser =
              IsPasswordValid("' INSERT INTO Users VALUES('hacker','') --",
              "qwerty123");

            Console.WriteLine(evilHackerCreatesNewUser);


            bool evilHackerDropDatabase =
           IsPasswordValid("'; DROP TABLE Test; --",
           "qwerty123");

            Console.WriteLine(evilHackerDropDatabase);
        }

        public static bool IsPasswordValid(string username, string password)
        {
            var dbConnection = "Data Source=.\\SQLEXPRESS;Database=Test;Integrated Security=true;";
            SqlConnection con = new SqlConnection(dbConnection);
            con.Open();

            string sql =
              $"SELECT COUNT(*) FROM Users " +
              $"WHERE Username = @username AND " +
              $"PasswordHash = @password";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            cmd.ExecuteNonQuery();

            int matchedUsersCount = (int)cmd.ExecuteScalar();
            con.Close();
            return matchedUsersCount > 0;

        }
    }
}
