using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_sequence
{
    class LongestSequence
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int br = 1;
            int br_max = br;
            int max_number = numbers[0];
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if(numbers[i] == numbers[i+1])
                {
                    br++;
                    if (br > br_max)
                    {
                        br_max = br;
                        max_number = numbers[i + 1];
                    }
                }
                else
                {
                    br = 1;
                }
            }
            var new_list = new List<int>();
            for (int i = 0; i < br_max; i++)
            {
                new_list.Add(max_number);
            }
            Console.WriteLine(string.Join(" ",new_list));
        }
    }
}
