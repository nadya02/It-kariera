using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_List
{
    class ReversedList_program
    {
        static void Main(string[] args)
        {
            ReversedList<int> rl = new ReversedList<int>();
            rl.Add(5);
            rl.Add(4);
            rl.Add(6);
            rl.Add(7);
            Console.WriteLine(rl.Count);
            Console.WriteLine(rl.RemoveAt(1));
            Console.WriteLine(rl.Count);
            foreach (int item in rl)
            {
                Console.WriteLine(item);
            }
        }
    }
}
