using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StorageMaster.Entities
{
    public abstract class Product
    {
        private double price;
        private double weight;

        protected Product(double price, double weight)
        {
            this.price = price;
            this.weight = weight;
        }

        public double Price
        {
            get { return price; }
            set
            {
                if(value < 0)
                {
                    throw new InvalidOperationException("Price cannot be negative!");
                }
                price = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
