using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_the_queue_row
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(n);
            for (int i = 1; i < 50; i+=3)
            {
                n = qu.Peek();
                qu.Enqueue(n + 1);
                qu.Enqueue(2 * n + 1);
                qu.Enqueue(n + 2);
            }
            Console.WriteLine(string.Join(" ", qu));
        }
    }
}
