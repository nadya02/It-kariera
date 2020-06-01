using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Product
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Product product;

        public Product Next
        {
            get { return product; }
            set { product = value; }
        }


        public Product(string name)
        {
            this.Name = name;
            this.Next = null;
        }


        public override string ToString()
        {
            return $"Product {Name}";
        }

    }
}
