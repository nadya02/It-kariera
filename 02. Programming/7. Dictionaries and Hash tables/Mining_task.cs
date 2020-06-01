using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mining_task
{
	class Mining_task
	{
		static void Main(string[] args)
		{
			string resource;
			int quantity;
			var minerals = new Dictionary<string, int>();	
			while((resource = Console.ReadLine()) != "stop")
			{
				quantity = int.Parse(Console.ReadLine());
				int value;
				if (minerals.ContainsKey(resource) == false)
				{
					minerals.Add(resource, quantity);
				}
				else
				{
					if (minerals.TryGetValue(resource, out value))
					{
						quantity = quantity + value;
					}
					minerals.Remove(resource);
					minerals.Add(resource, quantity);
				}
			}
			foreach(var item in minerals)
			{ 
				Console.WriteLine("{0} -> {1}",item.Key,item.Value);
			}
		}
	}
}
