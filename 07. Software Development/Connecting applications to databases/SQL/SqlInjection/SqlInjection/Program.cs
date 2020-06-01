using System;
using System.Data.SqlClient;
using System.Text;

namespace SqlInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //site for sql injection https://sqlzoo.net/hack/
            bool normalLogin = IsPasswordValid("peter", "qwerty123"); // true
            //проверява дали има такъв потребител с такава парола

            Console.WriteLine(normalLogin);

            bool sqlInjectedLogin = IsPasswordValid(" ' or 1=1 --", "qwerty123"); // true
             
            Console.WriteLine(sqlInjectedLogin);

            bool sqlInjectedLogin2 = IsPasswordValid(" ' or 1=1 --", " ' or 1=1 --");

            Console.WriteLine(sqlInjectedLogin2);

            bool evilHackerCreatesNewUser = IsPasswordValid("' INSERT INTO Users VALUES('hacker','') --",
            "qwerty123");

            Console.WriteLine(evilHackerCreatesNewUser);

            bool evilHackerDropDatabase = IsPasswordValid("'; DROP TABLE Test; --",
           "qwerty123");

            Console.WriteLine(evilHackerDropDatabase);
        }
        public static bool IsPasswordValid(string username, string password)
        {
            var dbConnection = "Data Source=.\\SQLEXPRESS; Database=Test; Integrated Security=true;";
            SqlConnection con = new SqlConnection(dbConnection);
            con.Open();

            string sql =
              $"SELECT COUNT(*) FROM Users " +
              $"WHERE Username = '{username}' AND " +
              $"PasswordHash = '{password}'";
            SqlCommand cmd = new SqlCommand(sql, con);


            int matchedUsersCount = (int)cmd.ExecuteScalar();
            con.Close();
            return matchedUsersCount > 0;

        }

    }
}
