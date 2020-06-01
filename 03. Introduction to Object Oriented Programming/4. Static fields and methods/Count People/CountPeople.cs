using System;

namespace CountPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Pesho", 12);
            Person p2 = new Person("Gosho", 15);
            Person p3 = new Person("Vladi", 17);
            Console.WriteLine(Person.Count);
        }
    }
}
