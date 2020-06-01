using StorageMaster.Entities.Products;
using StorageMaster.Entities.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Entities.Storage
{
    public abstract class Storage
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int GarageSlots { get; set; }

        private readonly Vehicle[] vehicles;
        public IReadOnlyCollection<Vehicle> Garage => vehicles;

        private readonly List<Product> trunk;
        public IReadOnlyCollection<Product> Products => trunk;

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

        public Vehicle GetVehicle(int garageSlot)
        {
            if(garageSlot >= GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
            if(IsEmpty())
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }
            return vehicles[garageSlot];
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle movedVehicle = GetVehicle(garageSlot);
            int emptySlot = 0;
            if(deliveryLocation.IsFull())
            {
                throw new InvalidOperationException("No room in garage!");
            }
            for (int i = 0; i < deliveryLocation.vehicles.Length; i++)
            {
                if(deliveryLocation.vehicles[i] == null)
                {
                    deliveryLocation.vehicles[i] = movedVehicle;
                    emptySlot = i;
                }
            }
            vehicles[garageSlot] = null;
            return emptySlot;
        }
        public int UnloadVehicle(int garageSlot)
        {
            if(IsFull())
            {
                throw new InvalidOperationException("Storage is full!");
            }
            Vehicle unloadingVehicle = GetVehicle(garageSlot);
            int count = 0;
            while(unloadingVehicle.IsFull() && unloadingVehicle.IsEmpty())
            {
                trunk.Add(unloadingVehicle.Unload());
                count++;
            }
            return count;
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
