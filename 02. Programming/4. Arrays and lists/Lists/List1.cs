using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Ani");
            names.Add("Kiki");
            names.Add("Bobi");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            names.Remove("Kiki");
            Console.WriteLine(String.Join(" ",names));
        }
    }
}
