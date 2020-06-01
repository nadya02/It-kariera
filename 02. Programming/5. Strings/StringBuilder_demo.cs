using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_demo
{
    class StringBuilder_demo
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();
            str.Append("Hello Maria, how are you?");
            Console.WriteLine(str);
            str[6] = 'D';
            Console.WriteLine(str);
            str.Remove(5, 6);
            Console.WriteLine(str);
            str.Insert(5, " Peter");
            Console.WriteLine(str);
            str.Replace(" Peter", " George");
            Console.WriteLine(str);
        }
    }
}
