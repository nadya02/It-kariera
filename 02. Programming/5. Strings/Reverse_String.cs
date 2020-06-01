using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
	class Reverse_String
	{
		static void Main(string[] args)
		{
			String input = Console.ReadLine();
			Console.WriteLine(Polindrom(input));
		}
		public static string Polindrom(String word)
		{
			StringBuilder reversed_word = new StringBuilder();
			for (int i = word.Length - 1; i >= 0; i--)
			{
				reversed_word.Append(word[i]);
			}
			return reversed_word.ToString();
		}
	}
}
