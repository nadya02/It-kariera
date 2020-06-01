using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string searched = Console.ReadLine();
            int br = 0;
            int pos = input.IndexOf(searched);
            while(pos !=  -1)
            {
                br++;
                pos = input.IndexOf(searched, pos + 1);
            }
            Console.WriteLine(br);
        }
    }
}
