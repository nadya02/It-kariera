using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_the_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number;
            Stack<int> st = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                st.Push(number);
            }
            while(st.Count != 0)
            {
                Console.WriteLine(st.Pop());
            }
        }
    }
}
