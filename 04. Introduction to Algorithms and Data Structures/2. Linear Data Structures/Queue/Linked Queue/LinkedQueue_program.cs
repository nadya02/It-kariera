using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LinkedQueue_program
{
    static void Main(string[] args)
    {
        LinkedQueue<int> lq = new LinkedQueue<int>();
        lq.Eneque(5);
        lq.Eneque(6);
        lq.Eneque(7);
        lq.Eneque(8);
        Console.WriteLine(lq.Count);
        Console.WriteLine();
        Console.WriteLine(lq.Deque());
        Console.WriteLine(lq.Count);
        Console.WriteLine(string.Join(" ", lq.ToArray()));
    }
}

