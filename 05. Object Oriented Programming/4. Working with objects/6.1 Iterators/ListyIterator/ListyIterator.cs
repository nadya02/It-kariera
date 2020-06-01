using System;
using System.Linq;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator_class<string> listy = new ListyIterator_class<string>();
            string[] input = Console.ReadLine().Split().ToArray();
            while(input[0] != "END")
            {
                switch(input[0])
                {
                    case "Create":
                        listy.Create(input.Skip(1).ToArray());
                        break;
                    case "HasNext":
                        Console.WriteLine(listy.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(listy.Move());
                        break;
                    case "Print":
                        listy.Print();
                        break;
                }
                input = Console.ReadLine().Split().ToArray();
            }

        }
    }
}
