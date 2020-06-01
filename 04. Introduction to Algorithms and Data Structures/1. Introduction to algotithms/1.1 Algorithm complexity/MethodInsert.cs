using System;
using System.Linq;

namespace Method_Insert
{
    class MethodInsert
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            int[] new_array = new int[array.Length + 1];
            Console.WriteLine(String.Join(" ",array));
            Insert(number, array, new_array);
            Console.WriteLine(String.Join(" ",new_array));
        }
        static public void Insert(int number, int[] numbers, int[] new_array)
        {
            int i = 0;
            while(numbers[i] <= number)
            { 
               new_array[i] = numbers[i];
               i++;
            }
            new_array[i] = number;
            for (int index = i+1;  index < new_array.Length; index++)
            {
                new_array[index] = numbers[index-1];
            }
        }
    }
}
