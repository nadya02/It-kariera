using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string listOfbeers = "Amstel, Zagorka, Tuborg, Becks.";
            string[] beers = listOfbeers.Split(new char[] {' ', ',', '.'},StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < beers.Length; i++)
            {
                 Console.WriteLine(beers[i]);
            }

        }
    }
}
