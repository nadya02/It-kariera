using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Skeleton
{
    class Train
    {
        private int number;
        private string name;
        private string type;
        private int cars;
        //може да не пишем полета - само със свойства също става

        public int Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public Train(int number, string name, string type, int cars)
        {
            this.Number = number;
            this.Name = name;
            this.Type = type;
            this.Cars = cars;
        }

        public override string ToString()
        {
            return $"{Number} {Name} {Type} {Cars}";
        }
    }
}
