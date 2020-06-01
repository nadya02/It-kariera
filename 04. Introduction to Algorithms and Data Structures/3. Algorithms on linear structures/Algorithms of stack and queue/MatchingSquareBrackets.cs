using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matching_square_brackets
{
    class MatchingSquareBrackets
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<int> st = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    st.Push(i);
                }
                else
                {
                    if(input[i] == ')')
                    {
                        int startIndex = st.Pop();
                        string contents = input.Substring(startIndex, i - startIndex + 1);
                        Console.WriteLine(contents);
                    }
                }
            }
        }
    }
}
