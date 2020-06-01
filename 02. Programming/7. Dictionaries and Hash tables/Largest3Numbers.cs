using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Numbers
{
	class Largest3Numbers
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine()
						.Split()
						.Select(int.Parse)
						.OrderByDescending(x => x)
						.Take(3)
						.ToArray();
			//var output = input.OrderByDescending(x => x).Take(3);
			Console.WriteLine(String.Join(" ",input));
		}
	}
}
