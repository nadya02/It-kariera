using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_inheritance
{
    class Hierarchical_Inheritance
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Console.WriteLine();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
