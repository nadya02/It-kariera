using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Anonymous_Cache
{
	class Program
	{
		static void Main(string[] args)
		{
			string input;
			var data = new Dictionary<string, Dictionary<string, long>>();
			var kesh = new Dictionary<string, Dictionary<string, long>>();
			while((input = Console.ReadLine()) != "thetinggoesskrra")
			{
				List<string> split_input = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
				int size = split_input.Count();
				string dataSet = "";
				if(size == 1)
				{
					dataSet = split_input[0];
					if (!data.ContainsKey(dataSet)) data[dataSet] = new Dictionary<string, long>();
					if(kesh.ContainsKey(dataSet))
					{
						data[dataSet] = new Dictionary<string, long>(kesh[dataSet]);
						kesh.Remove(dataSet);
					}					
				}
				else
				{
					string dataKey = split_input[0];
					long dataSize = long.Parse(split_input[1]);
					dataSet = split_input[2];
					if (!data.ContainsKey(dataSet))
					{
						if(!kesh.ContainsKey(dataSet)) kesh[dataSet] = new Dictionary<string,long>();
						kesh[dataSet].Add(dataKey, dataSize);
					}
					else
					{
						data[dataSet].Add(dataKey, dataSize);
					}
				}
			}
			if(data.Count > 0)
			{
				var result = data.OrderByDescending(x => x.Value.Sum(y => y.Value)).First();
				Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Sum(d => d.Value)}");
				foreach (var item in result.Value)
				{
					Console.WriteLine($"$.{item.Key}");
				}
			}
		}
	}
}
