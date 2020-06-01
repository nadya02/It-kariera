using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Person_program
{
    class Person_program
    {
        static void Main(string[] args)
        {
           /* Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);*/

            var input = Console.ReadLine().Split();
            Person p = new Person();
            p.Name = input[0];
            p.Age = int.Parse(input[1]);

            Console.WriteLine($"{p.Name}, {p.Age}");
        }
    }
}
