using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_by_rows
{
	class Average_by_rows
	{
		static void Main(string[] args)
		{
			int rows = int.Parse(Console.ReadLine());
			int cols = int.Parse(Console.ReadLine());
			int[,] a = new int[rows, cols];
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					a[i, j] = int.Parse(Console.ReadLine());
				}
			}
			for (int i = 0; i < rows; i++)
			{
				double sum = 0;
				for (int j = 0; j < cols; j++)
				{
					Console.Write("{0,10}", a[i, j]);
					sum = sum + a[i, j];
				}
				Console.Write("{0,10}",(double)sum/cols);
				Console.WriteLine();
			}
		}
	}
}
