using System;
using System.Collections.Generic;
using System.Linq;

namespace Compare_Objects
{
    class CompareObjects
    {
        static void Main(string[] args)
        {
            string input;
            List<Person> people = new List<Person>();
            while((input = Console.ReadLine()) != "END")
            {
                string[] splitInput = input.Split().ToArray();
                Person person = new Person(splitInput[0], int.Parse(splitInput[1]), splitInput[2]);
                people.Add(person);
            }
            int n = int.Parse(Console.ReadLine());
            Person comparablePerson = people[n- 1];

            int equalCount = 0;
            int differentCount = 0;

            foreach (var person in people)
            {
                if(person.CompareTo(comparablePerson) == 0)
                {
                    equalCount++;
                }
                else
                {
                    differentCount++;
                }
            }

            if(equalCount <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalCount} {differentCount} {people.Count}");
            }
        }
    }
}
