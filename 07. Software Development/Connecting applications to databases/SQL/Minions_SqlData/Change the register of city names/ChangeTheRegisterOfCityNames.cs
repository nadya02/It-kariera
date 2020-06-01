using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Change_the_register_of_city_names
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server = DESKTOP-1817IFM\\SQLEXPRESS; Database = MinionsDB; integrated security = true;";
            SqlConnection connection = new SqlConnection(connectionString);

            string countryName = Console.ReadLine();
            using (connection)
            {
                connection.Open();

                string countryQuery = $"select Name from countries where Name = '{countryName}';";
                SqlCommand command = new SqlCommand(countryQuery, connection);
                if(command.ExecuteScalar() == null)
                {
                    Console.WriteLine($"No country with the name {countryName}."); ;
                }
                else
                {
                    countryQuery = $"select id from countries where Name = '{countryName}';";
                    command = new SqlCommand(countryQuery, connection);
                    int countryId = int.Parse(command.ExecuteScalar().ToString());

                    string townQuery = $"select (count)* from Towns where CountryCode = '{countryId}';";
                    command = new SqlCommand(townQuery, connection);
                    int count = int.Parse(command.ExecuteScalar().ToString());

                    if(count == 0)
                    {
                        Console.WriteLine("No town names were affected.");
                    }
                    else
                    {
                        List<string> townsNamesAffected = new List<string>();
                        List<int> townsIdsAffected = new List<int>();

                        string townsQuery = $"select (id, name) from Towns where CountryCode = '{countryId};'";
                        command = new SqlCommand(townQuery, connection);
                        SqlDataReader reader = command.ExecuteReader();

                        while(reader.Read())
                        {
                            string townName = (string)reader["Name"];
                            int townId = (int)reader["id"];

                            townsNamesAffected.Add(townName.ToUpper());
                            townsIdsAffected.Add(townId);
                        }

                        for (int i = 0; i < count; i++)
                        {
                            townQuery = $"update Towns set Name = '{townsNamesAffected[i]}' where id = '{townsIdsAffected[i]}';";
                            command = new SqlCommand(townQuery, connection);
                            command.ExecuteNonQuery();
                        }
                      
                        Console.WriteLine($"{count} town names were affected.");
                        Console.WriteLine($"[{String.Join(", ", townsNamesAffected)}");
                    }
                }
            }
        }
    }
}
