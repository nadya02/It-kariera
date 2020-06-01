using System;
using System.Linq;

namespace Search_in_ordered_array
{
    class SearchInOrderedArray
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            int right_board = array.Length - 1;
            int left_board = 0;
            while(left_board <= right_board)
            {
                int mid = (left_board + right_board) / 2;
                if (array[mid] == number)
                {
                    Console.WriteLine($"{number} Exists in the List");
                    return;
                }
                else
                {
                    if(number < array[mid])
                    {
                        right_board = mid - 1;
                    }
                    else
                    {
                        left_board = mid + 1;
                    }
                }
            }
            Console.WriteLine($"{number} Not exists in the List");
        }
    }
}
