using System;
using System.Data.SqlClient;

namespace Softuni_sqlClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //следващия ред ни казва коя е базата данни и къде е
            string connectionString = "Server = DESKTOP-1817IFM\\SQLEXPRESS; Database = softuni; Integrated security = true;";
            //integreted security - използва security на windows
            // щом windows ни е пуснал да работим значи и то ще даде достъп до datebase 
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                connection.Open();//отваряме conection-a
                string query = "Select Count(*) from employees";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                //казва ме коя ще е командата
                int count = int.Parse(sqlCommand.ExecuteScalar().ToString());
                //ExecuteScalar - връща 1 нещо(1вото от всичко, което е прочел)               
                Console.WriteLine(count);

                query = "Select *from employees";
                sqlCommand = new SqlCommand(query, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                //execute reader - чете таблици и за всеки ред клетка по клетка чете съдържанието
                while (sqlDataReader.Read())
                {
                    Console.WriteLine($"{sqlDataReader[0]} {sqlDataReader[1]} {sqlDataReader[2]}");
                }
            }
            //using - когато се изпълни действието в скобите{} на using -> connection се унищожава
        }
    }
}
