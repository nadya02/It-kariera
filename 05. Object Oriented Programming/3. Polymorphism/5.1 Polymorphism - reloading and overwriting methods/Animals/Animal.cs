using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string favouriteFood;

        public string FavouriteFood
        {
            get { return favouriteFood; }
            set { favouriteFood = value; }
        }

        public Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public virtual string ExplainMyself()
        {
            return $"I am {Name} and my fovourite food is {FavouriteFood}";
        }
    }
}
