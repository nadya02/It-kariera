using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] baned = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();
            for (int i = 0; i < baned.Length; i++)
            {
                text = text.Replace(baned[i], new string('*', baned[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}
