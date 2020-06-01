using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MathOperations
{
    class MathOperations
    {
        static void Main(string[] args)
        {
                MathOperations_class mo = new MathOperations_class();
                Console.WriteLine(mo.Add(2, 3));
                Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
                Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));
        }
    }
}
