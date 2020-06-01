using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CRUD_App_Without_ORM.Data
{
    //подържа връзката с БД
    //подава се низа за връзка с базата данни
    public static class DataBase
    {
        private static string connectionString = "Server = DESKTOP-1817IFM\\SQLEXPRESS; Database = shop; Integrated security = true;";
        
        //хубаво е да се обосовяват в отделни класове
        //конекцията може да се ипозлва и от други класове
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
