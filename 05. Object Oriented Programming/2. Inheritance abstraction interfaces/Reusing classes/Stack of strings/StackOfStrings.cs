using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_of_strings
{
    class StackOfStrings
    {
        static void Main(string[] args)
        {
            StackOfStrings_class stackOfStrings = new StackOfStrings_class();
            var input = Console.ReadLine().Split();
            foreach (var item in input)
            {
                stackOfStrings.Push(item);
            }
            Console.WriteLine(stackOfStrings);
            Console.WriteLine(stackOfStrings.Pop());
            Console.WriteLine(stackOfStrings.Peek());
            Console.WriteLine(stackOfStrings.IsEmpty());
        }
    }
}
