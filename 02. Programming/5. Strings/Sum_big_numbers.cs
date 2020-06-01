using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_big_numbers
{
	class Sum_big_numbers
	{
		static void Main(string[] args)
		{
			string first_number = Console.ReadLine();
			string second_number = Console.ReadLine();
			int length;
			if (first_number.Length > second_number.Length)
			{
				length = first_number.Length;
				for (int i = second_number.Length; i < length; i++)
				{
					second_number = "0" + second_number;
				}
			}
			else
			{
				length = second_number.Length;
				for (int i = first_number.Length; i < length; i++)
				{
					first_number = "0" + first_number;
				}
			}
			int naum = 0;
			string sum = "";
			for (int i = length - 1; i >= 0; i--)
			{
				int x = (first_number[i] - '0') + (second_number[i] - '0') + naum;
				int c = x % 10;
				sum = c.ToString() + sum;
				naum = x / 10;
			}
			if (naum > 0) sum = naum + sum;
			Console.WriteLine(sum);
		}
	}
}
