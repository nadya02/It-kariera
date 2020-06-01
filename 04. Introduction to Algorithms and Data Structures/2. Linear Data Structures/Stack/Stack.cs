using System;

namespace Stack
{
    class Stack
    {
        static void Main(string[] args)
        {
            ArrayStack<int> ars = new ArrayStack<int>();
            ars.Push(4);
            ars.Push(5);
            ars.Push(6);
            ars.Push(7);
            Console.WriteLine(ars.Count);
            Console.WriteLine(ars.Pop());
            Console.WriteLine(ars.Count);
            Console.WriteLine(String.Join(" ", ars.ToArray()));
        }
    }
}
