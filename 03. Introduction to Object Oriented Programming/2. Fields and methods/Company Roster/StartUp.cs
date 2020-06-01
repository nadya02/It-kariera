using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<Employee>>();          
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string position = input[2];
                string department = input[3];
                string email = "n/a";
                int age = -1;
                if(input.Length == 6)
                {
                    email = input[4];
                    age = int.Parse(input[5]);
                }
                if(input.Length == 5)
                {
                    if(input[4].Contains("@"))
                    {
                        email = input[4];
                    }
                    else
                    {
                        age = int.Parse(input[4]);
                    }
                }
                Employee person = new Employee(name, salary, position, department, email, age);
                if(!dict.ContainsKey(department))
                {
                    dict[department] = new List<Employee>();
                }
                dict[department].Add(person);
            }

            var d = dict.OrderByDescending(departament => departament.Value.Average(employee => employee.Salary)).First();
            Console.WriteLine("Highest Average Salary: " + d.Key);
            foreach (var empl in d.Value.OrderByDescending(X => X.Salary))
            {
                Console.WriteLine($"{empl.Name} {empl.Salary:f2} {empl.Email} {empl.Age}");
            }
        }
    }
}
