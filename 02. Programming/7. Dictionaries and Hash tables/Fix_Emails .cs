using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Emails
{
	class Program
	{
		static void Main(string[] args)
		{
			var dict = new Dictionary<string, string>();
			string name;
			while((name = Console.ReadLine()) != "stop")
			{
				string email = Console.ReadLine();
				string[] split_email = email.Split('.');
				if(split_email[1] != "uk" && split_email[1] != "us")
				{
					dict.Add(name, email);
				}
			}
			foreach(var item in dict)
			{
				Console.WriteLine("{0} -> {1}", item.Key, item.Value);
			}
		}
	}
}
