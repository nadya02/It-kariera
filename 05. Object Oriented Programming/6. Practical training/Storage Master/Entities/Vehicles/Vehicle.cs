using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Vehicles
{
    public abstract class Vehicle
    {
        private int capacity;
        private Stack<Product> trunk;
        public IReadOnlyCollection<Product> Trunk => trunk;

        protected Vehicle(int capacity)
        {
            this.capacity = capacity;
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public bool IsFull()
        {
            double sum = 0;
            foreach (var products in Trunk)
            {
                sum += products.Weight;
            }
            if(sum >= Capacity)
            {
                return true;
            }
            return false;
        }

        public bool IsEmpty()
        {
            if(Trunk.Count == 0)
            {
                return true;
            }
            return false;
        }

        public void LoadProduct(Product product)
        {
            if(IsFull() == true)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            else
            {
                trunk.Push(product);
            }
        }

        public Product Unload()
        {
            if(IsEmpty() == true)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            else
            {
                return trunk.Pop();
            }
        }
    }
}
