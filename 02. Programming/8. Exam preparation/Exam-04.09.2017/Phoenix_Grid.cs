using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Grid
{
    class Phoenix_Grid
    {
        static void Main(string[] args)
        {
            string input;
            
            while((input = Console.ReadLine()) != "ReadMe")
            {
                bool flag = true;
                if (input.Length % 4 != 3) flag = false;
                if (input.IndexOf('_') != -1) flag = false;
                if (input.IndexOf(' ') != -1) flag = false;
                if (input.IndexOf('\t') != -1) flag = false;
                for (int i = 3; i < input.Length; i += 4)
                {
                    if (input[i] != '.') flag = false;
                }
                string reversedInput = "";
                if(flag == true)
                {
                    for (int i = input.Length - 1; i >= 0; i--)
                    {
                        reversedInput += input[i];
                    }
  
                }
                if (reversedInput == input) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
        }
    }
}
