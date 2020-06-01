using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_big_number
{
	class Program
	{
		static void Main(string[] args)
		{
			string first_number = Console.ReadLine().TrimStart(new char[] { '0' });
			int second_number = int.Parse(Console.ReadLine());
			int naum = 0;
			string sum = "";
			for (int i = first_number.Length - 1; i >= 0; i--)
			{
				int x = (first_number[i] - '0') * second_number + naum;
				int c = x % 10;
				sum = c.ToString() + sum;
				naum = x / 10;
			}
			if (naum > 0) sum = naum + sum;
			if (first_number == "0" || second_number == 0 || first_number == "")
			{
				sum = "0";
			}
			Console.WriteLine(sum);
		}
	}
}
