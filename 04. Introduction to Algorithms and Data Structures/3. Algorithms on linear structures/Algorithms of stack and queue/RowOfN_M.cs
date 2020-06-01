using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Row_of_n_m
{
    class RowOfN_M
    {
        static void Main(string[] args)
        {
            Queue<Element> qu = new Queue<Element>();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = numbers[0];
            int m = numbers[1];
            qu.Enqueue(new Element(n, null));
            while(qu.Count != 0)
            {
                Element t = qu.Dequeue();
                if(t.Value < m)
                {
                    qu.Enqueue(new Element(t.Value + 1, t));
                    qu.Enqueue(new Element(t.Value + 2, t));
                    qu.Enqueue(new Element(t.Value * 2, t));
                }
                if(t.Value == m)
                {
                    PrintSolution(t.Previous);
                    Console.WriteLine(t.Value);
                    return;//първата измерена е най-късата
                }
            }
            Console.WriteLine("(няма решение)");
            return;
        }

        private static void PrintSolution(Element t)
        {
            if(t != null)
            {
                PrintSolution(t.Previous);
                Console.Write(t.Value + " -> ");
            }
        }
    }

    public class Element
    {
        public int Value { get; set; }
        public Element Previous { get; set; }
        public Element(int value, Element previous)
        {
            Value = value;
            Previous = previous;
        }
    }
}
