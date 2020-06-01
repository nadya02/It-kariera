using System;
using System.Data.SqlClient;

namespace MinionsNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server = DESKTOP-1817IFM\\SQLEXPRESS; Database = MinionsDB; integrated security = true;";
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                connection.Open();
                int villianId = int.Parse(Console.ReadLine());
                string idQuery = $"select id from villians where id = {villianId};";
                SqlCommand command = new SqlCommand(idQuery, connection);
                if (command.ExecuteScalar() == null)
                {
                    Console.WriteLine($"No villain with ID {villianId} exists in the database.");
                }
                else
                {
                    string villianNameQuery = $"select Name from villians where id = {villianId};";
                    command = new SqlCommand(villianNameQuery, connection);
                    Console.WriteLine($"Villian: {command.ExecuteScalar().ToString()}");
                    string minionsNamesQuery = $@"select m.Name, m.Age
                                                  from Minions as m
                                                  join MinionsVillians as mv
                                                  on mv.MinionId = m.id
                                                  where mv.VillianId = {villianId}
                                                  order by m.Name asc;";
                    command = new SqlCommand(minionsNamesQuery, connection);
                    if (command.ExecuteScalar() == null)
                    {
                        Console.WriteLine("(no minions)");
                    }
                    else
                    {
                        SqlDataReader sqlDataReader = command.ExecuteReader();
                        int count = 0;
                        while (sqlDataReader.Read())
                        {
                            count++;
                            Console.WriteLine($"{count}. {sqlDataReader[0]} {sqlDataReader[1]}");
                        }
                    }
                }
            }
        }
    }
}
      