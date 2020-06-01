using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "Hello";
            string m = "World";
            object p = n + " " + m;
            string d = (string)p;
            Console.WriteLine(d);
        }
    }
}
