using System;
using CodeFirstDB.Data;

namespace CodeFirstDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WorkContext context = new WorkContext())
            {
                if (context.Database.EnsureCreated()) Console.WriteLine("Yes"); ;

            }
        }
    }
}
