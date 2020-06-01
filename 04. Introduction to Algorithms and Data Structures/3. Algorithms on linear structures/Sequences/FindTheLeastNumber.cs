using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_least_number
{
    class FindTheLeastNumber
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int min = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine(min);
        }
    }
}
