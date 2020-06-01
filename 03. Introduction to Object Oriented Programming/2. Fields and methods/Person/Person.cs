using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_program
{
    class Person
    {
        private int age;
        private string name;

        public int Age
        {
            get{ return this.age; }
            set{ this.age = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
