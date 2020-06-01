using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
	class Supermarket
	{
		static void Main(string[] args)
		{
			var supermarket_quantity = new Dictionary<string, int>();
			var supermarket_price = new Dictionary<string, double>();
			string input;
			while ((input = Console.ReadLine()) != "stocked")
			{
				int value;
				var SplitInput = input.Split();
				var price = double.Parse(SplitInput[1]);
				var quantity = int.Parse(SplitInput[2]);
				if (supermarket_price.ContainsKey(SplitInput[0]) == false)
				{
					supermarket_price.Add(SplitInput[0], price);
				}
				else
				{
					supermarket_price.Remove(SplitInput[0]);
					supermarket_price.Add(SplitInput[0], price);
				}
				if(supermarket_quantity.ContainsKey(SplitInput[0]) == false)
				{
					supermarket_quantity.Add(SplitInput[0], quantity);
				}
				else
				{
					if (supermarket_quantity.TryGetValue(SplitInput[0], out value))
					{
						 quantity = quantity + value;
					}
					supermarket_quantity.Remove(SplitInput[0]);
					supermarket_quantity.Add(SplitInput[0], quantity);
				}

			}
			double GrandTotal = 0;
			foreach (var item in supermarket_price)
			{
				var total = item.Value * supermarket_quantity[item.Key];
				GrandTotal = GrandTotal + total;
				Console.WriteLine("{0}: ${1:F2} * {2} = ${3:F2}", item.Key, item.Value, supermarket_quantity[item.Key], total);
			}
			Console.WriteLine("------------------------------");
			Console.WriteLine("Grand Total: ${0:F2}",GrandTotal);
		}
	}
}
