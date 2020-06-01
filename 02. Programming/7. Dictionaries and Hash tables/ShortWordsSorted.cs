using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Words_Sorted
{
	class ShortWordsSorted
	{
		static void Main(string[] args)
		{
			char[] separetors = ".,:;()[]\"'!? ".ToCharArray();
			var text = Console.ReadLine()
				.Split(separetors, StringSplitOptions.RemoveEmptyEntries)
				.Where(x => x.Length < 5)
				.OrderBy(x => x)
				.Distinct()
				.ToArray();
			Console.WriteLine(String.Join(", ",text));
		}
	}
}
