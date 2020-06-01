using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series_of_numbers
{
    class SeriesOfNumbers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(N);
            int index = 0;
            while(qu.Peek() != P)
            {
                N = qu.Dequeue();
                index++;
                qu.Enqueue(N + 1);
                qu.Enqueue(N * 2);
            }
            Console.WriteLine(index + 1);
        }
    }
}
