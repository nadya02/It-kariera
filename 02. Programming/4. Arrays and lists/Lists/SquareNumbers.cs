using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort();
            nums.Reverse();
            for (int i = 0; i < nums.Count; i++)
            {
                int x =(int)Math.Sqrt(nums[i]);
                if (x * x == nums[i]) Console.Write(nums[i]+" ");
            }

            Console.WriteLine();
        }
    }
}
