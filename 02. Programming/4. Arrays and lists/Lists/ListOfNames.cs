﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfNames
{
    class ListOfNames
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();
            names.Reverse();
            Console.WriteLine(String.Join(";",names));
        }
    }
}
