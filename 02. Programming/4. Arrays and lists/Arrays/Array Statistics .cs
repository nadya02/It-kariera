using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int min = nums[0];
            int max = nums[0];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (max < nums[i]) max = nums[i];
                if (min > nums[i]) min = nums[i];
                sum = sum + nums[i];
            }
            double average;
            average = (double)(sum )/ (nums.Length);
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + average);
        }
    }
}
