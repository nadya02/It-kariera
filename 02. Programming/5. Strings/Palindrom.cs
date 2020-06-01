using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
	class Palindrom
	{
		static void Main(string[] args)
		{
			String input = Console.ReadLine();
			Console.WriteLine(IsPolindrom(input));
		}
		public static bool IsPolindrom(String word)
		{
			StringBuilder reversed_word = new StringBuilder();
			for (int i = word.Length - 1; i >= 0; i--)
			{
				reversed_word.Append(word[i]);
			}
			reversed_word.ToString();
			if (reversed_word.ToString() == word) return true;
			else return false;
		}
	}
}
