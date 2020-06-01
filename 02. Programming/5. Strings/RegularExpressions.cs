using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace RegularExoresions
{
    class RegularExpressions
    {
        static void Main(string[] args)
        {
            string str = "Pesho: 0887625585 \nGosho: 0897865413 \n Ivan: 0875891236";
            string repl = Regex.Replace(str, "(08)[0-9]{8}", "$1********");
            string repl1 = Regex.Replace(str, "[0-9]{10}", "08********");
            Console.WriteLine(repl);
            Console.WriteLine(repl1);
        }
    }
}
