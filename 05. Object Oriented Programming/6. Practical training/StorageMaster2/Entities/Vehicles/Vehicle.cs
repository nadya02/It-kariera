using StorageMaster.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Entities.Vehicles
{
    public abstract class Vehicle
    {
        public int Capacity { get; set; }

        private Stack<Product> trunk;
        public IReadOnlyCollection<Product> Trunk => trunk;

        public Vehicle(int capacity)
        {
            Capacity = capacity;
        }

        public void LoadProduct(Product product)
        {
            if (IsFull() == true)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            trunk.Push(product);
        }

        public Product Unload()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            return trunk.Pop();
        }
        public bool IsFull()
        {
            if (trunk.Sum(x => x.Weight) >= Capacity)
            {
                return true;
            }
            return false;
        }

        public bool IsEmpty()
        {
            if (Capacity == 0)
            {
                return true;
            }
            return false;
        }
    }
}
