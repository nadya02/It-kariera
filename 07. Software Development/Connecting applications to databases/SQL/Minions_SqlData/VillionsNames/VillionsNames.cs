using System;
using System.Data.SqlClient;

namespace VillionsNames
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
                var sql = @"select v.Name, Count(MinionId) as c
                            from Villians as v
                            join MinionsVillians
                            on id = VillianId
                            group by v.Name
                            having Count(MinionId) >= 3
                            order by c desc;";
                /*
                 * var sql = @"select v.Name, 
                                (select count(*) from MinionsVillians where VillianId = v.id) as Minion_Count
                                from villians as v
                                where (select count(*) from MinionsVillians where VillianId = v.id) > 3
                                order by Minion_Count desc;";
                 */
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine($"{reader[0]}: {reader[1]}");
                }
            }
        }
    }
}
