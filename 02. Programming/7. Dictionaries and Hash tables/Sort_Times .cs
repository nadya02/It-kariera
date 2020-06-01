using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var TimeList = Console.ReadLine().Split(' ').OrderBy(x => x).ToList();
            Console.WriteLine(String.Join(", ",TimeList));
        }
    }
}
