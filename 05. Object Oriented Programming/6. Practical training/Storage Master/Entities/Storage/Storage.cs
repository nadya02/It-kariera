using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Entities.Storage
{
    public abstract class Storage
    {
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public int GarageSlots { get; set; }
        public string Name { get; set; }

        private readonly List<Product> trunk;
        public IReadOnlyCollection<Product> Products => trunk;

        private readonly Vehicle[] vehicles;
        public IReadOnlyCollection<Vehicle> Garage => vehicles;

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> Vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;

            this.trunk = new List<Product>();

            this.vehicles = new Vehicle[garageSlots];
            int i = 0;
            foreach (var vehicle in Vehicles)
            {
                vehicles[i] = vehicle;
                i++;
            }
        }

        public bool IsFull()
        {
            if(trunk.Sum(x => x.Weight) >= Capacity)
            {
                return true;
            }
            return false;
        }

        public Vehicle GetVehicle(int garageSlot)
        {
            if(garageSlot >= GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
            if(GarageSlots == 0)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }
            return vehicles[garageSlot];
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = GetVehicle(garageSlot);
            int emptySlot = EmptySlot(deliveryLocation);
            if(emptySlot == -1)
            {
                throw new InvalidOperationException("No room in garage!");
            }
            deliveryLocation.vehicles[emptySlot] = vehicle;
            this.vehicles[garageSlot] = null;
            return emptySlot;
        }

        public int UnloadVehicle(int garageSlot)
        {
            if(IsFull() == true)
            {
                throw new InvalidOperationException("Storage is full!");
            }
            Vehicle vehicle = GetVehicle(garageSlot);
            int countUnloadedProducts = 0;
            while (vehicle.IsEmpty() && vehicle.IsFull())
            {
                trunk.Add(vehicle.Unload());
                countUnloadedProducts++;
            }
            return countUnloadedProducts;
        }

        private int EmptySlot(Storage storage)
        {
            for (int i = 0; i < storage.vehicles.Length; i++)
            {
                if(storage.vehicles[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
