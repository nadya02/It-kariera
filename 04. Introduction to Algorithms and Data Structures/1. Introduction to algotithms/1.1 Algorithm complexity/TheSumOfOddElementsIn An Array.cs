using System;
using System.Linq;

namespace Find_the_sum_of_the_steps
{
    class FindTheSumOfTheSteps
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum_odd = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    sum_odd += numbers[i];
                }
            }
            Console.WriteLine(sum_odd);
            /* 9n+3 - броя на стъпките
             * като n е броя на въведените числа*/
        }
    }
}