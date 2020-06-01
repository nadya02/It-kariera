using System;
using System.Linq;

namespace Does_a_given_array_number_exist
{
    class DoesAGivenArrayNumberExist
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            bool flag = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(number == numbers[i])
                {
                    Console.WriteLine($"{number} Exists in the List");
                    flag = true;
                    break;
                }
            }
            if(flag == false)
            {
                 Console.WriteLine($"{number} Not exists in the List");
            }
        }
    }
}
