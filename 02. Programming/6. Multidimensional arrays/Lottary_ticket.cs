using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottary_ticket
{
	class Lottary_ticket
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int m = int.Parse(Console.ReadLine());
			int[,] a = new int[n, m];
			for (int i = 0; i < n; i++)
			{
				int[] tempA = Console.ReadLine().Split().Select(int.Parse).ToArray();
				for (int j = 0; j < m; j++)
				{
					a[i, j] = tempA[j];
				}
			}
			int sum1 = 0,sumNad = 0,sumPod = 0, sum2 = 0, sumeven1 = 0;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					if (i == j)
					{
						sum1 = sum1 + a[i, j];
						if (a[i, j] % 2 == 0) sumeven1 = sumeven1 + a[i, j];
					}
					if (i < j) sumNad = sumNad + a[i, j];
					if(i > j) sumPod = sumPod + a[i, j];
					if ((i + j) == n - 1) sum2 = sum2 + a[i, j];
				}
			}
			if (sum1 == sum2)
			{
				if (sumNad % 2 == 0)
				{
					if (sumPod % 2 != 0)
					{
						Console.WriteLine("YES");
					}
				}
			}
			int SumRowEven = 0;
			int SumColOdd = 0;
			double average = 1;
			for (int j = 0; j < m; j++)
			{
				if (a[0, j] % 2 == 0 || a[n - 1, j] % 2 == 0)
				{
					if(a[n - 1, j] % 2 == 0) SumRowEven = SumRowEven + a[n-1, j];
					if(a[0, j] % 2 == 0) SumRowEven = SumRowEven + a[0, j];
				}
			}
			for (int i = 0; i < n; i++)
			{
				if (a[i, 0] % 2 != 0 || a[i, m - 1] % 2 != 0)
				{
					if (a[i, m - 1] % 2 != 0) SumColOdd = SumColOdd + a[i, m-1];
					if (a[i, 0] % 2 != 0) SumColOdd = SumColOdd + a[i, 0];
				}
			}
			average = (SumRowEven + SumColOdd + sumeven1 + sumPod) / 4;
			Console.WriteLine("The amount of money won is: {0:f2}", average);
		}
	}
}
