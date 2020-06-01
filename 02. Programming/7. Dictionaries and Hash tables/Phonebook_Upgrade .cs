using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
	class Phonebook
	{
		static void Main(string[] args)
		{
			var Phonebook = new SortedDictionary<string, string>();
			string[] input = Console.ReadLine().Trim().Split(' ');
			while (input[0] != "END")
			{
				var value = "";
				if (input[0] == "A")
				{
					if (Phonebook.ContainsKey(input[1]) == false)
					{
						Phonebook.Add(input[1], input[2]);
					}
					else
					{
						Phonebook.Remove(input[1]);
						Phonebook.Add(input[1], input[2]);
					}
				}
				else
				{
					if (input[0] == "S")
					{
						if (Phonebook.ContainsKey(input[1]))
						{
							if (Phonebook.TryGetValue(input[1], out value))
							{
								Console.WriteLine("{0} -> {1}", input[1], value);
							}
						}
						else
						{
							Console.WriteLine("Contact {0} does not exist.", input[1]);
						}
					}
					else
					{
						foreach(var item in Phonebook)
						{
							Console.WriteLine("{0} -> {1}",item.Key,item.Value);
						}
					}
				}
				input = Console.ReadLine().Split(' ');
			}

		}
	}
}

