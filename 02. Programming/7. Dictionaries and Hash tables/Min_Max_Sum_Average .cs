using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Max_Sum_Average
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			for (int i = 0; i < n; i++)
			{
				a[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Sum = " + a.Sum());
			Console.WriteLine("Min = " + a.Min());
			Console.WriteLine("Max = " + a.Max());
			Console.WriteLine("Average = " + a.Average());
		}
	}
}
