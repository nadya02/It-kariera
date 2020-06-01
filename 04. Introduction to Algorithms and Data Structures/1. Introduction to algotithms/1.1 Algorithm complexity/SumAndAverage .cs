using System;
using System.Linq;

namespace Sum_and_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if(input == " ")
            {
                Console.WriteLine("Sum=0; Average=0.00");
            }
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            int sum = array.Sum(x => x);
            double average = array.Average(x => x);
            Console.WriteLine($"Sum={sum}; Average={average:f2}");
        }
    }
}
