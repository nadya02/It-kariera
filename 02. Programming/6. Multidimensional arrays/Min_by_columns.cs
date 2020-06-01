using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_by_columns
{
	class Min_by_columns
	{
		static void Main(string[] args)
		{
			int rows = int.Parse(Console.ReadLine());
			int cols = int.Parse(Console.ReadLine());
			int[,] a = new int[rows, cols];
			for (int i = 0; i < rows; i++)
			{
				int[] tempArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				for (int j = 0; j < cols; j++)
				{
					a[i, j] = tempArray[j];
				}
			}
			Console.WriteLine();
			int[] temp = new int[cols];
			for (int j = 0; j < cols; j++)
			{
				int min = a[0, j];
				for (int i = 0; i < rows; i++)
				{
					if (a[i, j] < min)
					{
						min = a[i, j];
						temp[j] = min;
					}
					else
					{
					//	min = a[0, j];
						temp[j] = min;
					}
				}
			}
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write(a[i,j] + " ");
				}
				Console.WriteLine(); 
			}
			Console.WriteLine(String.Join(" ",temp));
		}

	}
}
