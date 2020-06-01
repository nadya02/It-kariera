using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_numbers_with_the_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> st = new Stack<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                st.Push(numbers[i]);
            }
            Console.WriteLine(String.Join(" ", st));
        }
    }
}
