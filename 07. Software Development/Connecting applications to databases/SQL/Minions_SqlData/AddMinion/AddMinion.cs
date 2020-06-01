using System;
using System.Data.SqlClient;

namespace AddMinion
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server = DESKTOP-1817IFM\\SQLEXPRESS; Database = MinionsDB; integrated security = true;";
            SqlConnection connection = new SqlConnection(connectionString);

            string[] input = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            string minionName = input[1];
            string minionAge = input[2];
            string minionTownName = input[3];
            input = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            string villianName = input[1];
            using (connection)
            {
                connection.Open();

                string townQuery = $"select Name from Towns where Name = '{minionTownName}';";
                string villianQuery = $"select Name from Villians where Name = '{villianName}';";

                SqlCommand command = new SqlCommand(townQuery, connection);
                if (command.ExecuteScalar() == null)
                {
                    townQuery = $"Insert into Towns (Name, CountryCode) values ('{minionTownName}', '2')";//CountryCode??
                    command = new SqlCommand(townQuery, connection);
                    command.ExecuteNonQuery();
                    Console.WriteLine($"Town {minionTownName} was added to the database.");
                }

                command = new SqlCommand(villianQuery, connection);
                if (command.ExecuteScalar() == null)
                {
                    villianQuery = $"Insert into Villians (Name, EvilnessFactorId) values ('{villianName}', '4')";
                    command = new SqlCommand(villianQuery, connection);
                    command.ExecuteNonQuery();
                    Console.WriteLine($"Villain {villianName} was added to the database.");
                }

                townQuery = $"select id from Towns where Name = '{minionTownName}';";
                command = new SqlCommand(townQuery, connection);
                int townId = int.Parse(command.ExecuteScalar().ToString());

                string addMinionQuery = $"Insert into Minions (Name, Age, TownId) values ('{minionName}', '{minionAge}', '{townId}')";
                command = new SqlCommand(addMinionQuery, connection);
                command.ExecuteNonQuery();

                villianQuery = $"select id from Villians where Name = '{villianName}';";
                command = new SqlCommand(villianQuery, connection);
                int villianId = int.Parse(command.ExecuteScalar().ToString());
                 
                string minionQuery = $"select id from Minions where Name = '{minionName}';";
                command = new SqlCommand(minionQuery, connection);
                int minionId = int.Parse(command.ExecuteScalar().ToString());

                string villianMinionQuery = $"insert into MinionsVillians (MinionId, VillianId) values ('{minionId}', '{villianId}');";
                command = new SqlCommand(villianMinionQuery, connection);
                command.ExecuteNonQuery();
                Console.WriteLine($"Successfully added {minionName} to be minion of {villianName}.");
            }
        }
    }
}
