using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy_template
{
    class StrategyТemplate
    {
        static void Main(string[] args)
        {
            SortedSet<Person> byName = new SortedSet<Person>(new NameComaprator());
            SortedSet<Person> byAge = new SortedSet<Person>(new AgeComparer());

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                Person person = new Person(input[0], int.Parse(input[1]));
                byName.Add(person);
                byAge.Add(person);
            }

            foreach (var person in byName)
            {
                Console.WriteLine(person.ToString());
            }

            foreach (var person in byAge)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
