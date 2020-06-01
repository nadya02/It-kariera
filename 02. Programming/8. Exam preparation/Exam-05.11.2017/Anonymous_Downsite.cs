using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Anonymous_Downsite
{
	class Anonymous_Downsite
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int key = int.Parse(Console.ReadLine());
			decimal totalLoss = 0;
			for (int i = 0; i < n; i++)
			{
				string[] website_information = Console.ReadLine().Split().ToArray();
				string siteName = website_information[0];
				decimal siteVisits = decimal.Parse(website_information[1]);
				decimal siteCommercialPricePerVisit = decimal.Parse(website_information[2]);
				Console.WriteLine(siteName);
				totalLoss = totalLoss + siteVisits * siteCommercialPricePerVisit;
			}
			Console.WriteLine($"Total Loss: {totalLoss:f20}");
			Console.WriteLine("Security Token: " + BigInteger.Pow(key,n));
		}
	}
}
