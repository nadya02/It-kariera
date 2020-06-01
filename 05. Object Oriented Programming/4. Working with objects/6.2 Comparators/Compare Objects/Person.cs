using System;
using System.Collections.Generic;
using System.Text;

namespace Compare_Objects
{
    class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string city;
        private int count = 0;

        public int Count
        {
            get { return count = 0; }
        }

        public Person(string name, int age, string city)
        {
            this.name = name;
            this.age = age;
            this.city = city;
            count++;
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

        public string City
        {
            get { return city; }
            set { city = value; }
        }


        public int CompareTo(Person other)
        {
            int result = Name.CompareTo(other.Name);
            if(result == 0)
            {
                result = Age.CompareTo(other.Age);
                if(result == 0)
                {
                    result = City.CompareTo(other.City);
                    return result;
                }
                return result;
            }
            return result;
        }
    }
}
