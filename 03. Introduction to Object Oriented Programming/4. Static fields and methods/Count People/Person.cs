using System;
using System.Collections.Generic;
using System.Text;

namespace CountPeople
{
    public class Person
    {
       
        private int age;
        private string name;
        private static int count = 0;

        public static int Count
        {
            get { return count; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name, int age)
        {
            Person.count += 1;
            this.Name = name;
            this.Age = age;
        }
    }
}

