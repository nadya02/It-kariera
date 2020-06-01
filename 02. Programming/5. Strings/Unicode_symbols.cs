using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_symbols
{
    class Unicode_symbols
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string strUni = "";
            for (int i = 0; i < n.Length; i++)
            {
                strUni = strUni + "\\u" + ((int)n[i]).ToString("X4").ToLower();
            }
            Console.WriteLine(strUni);
        }
    }
}
