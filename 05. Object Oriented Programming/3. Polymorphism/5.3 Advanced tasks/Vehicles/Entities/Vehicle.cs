using System;
using System.Collections.Generic;
using System.Text;
using Vehicles_rightWay.Interfaces;

namespace Vehicles_rightWay.Entities
{
    public abstract class Vehicle : IVehicle
    {
        public double FuelPerKm { get; set; }
        public double FuelQuantity { get; set; }

        protected Vehicle(double fuelQuantity, double fuelPerKm)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelPerKm = fuelPerKm;
        }

        public virtual string Drive(double distance, double increaseFuel)
        {
            double consumption = distance * (FuelPerKm + increaseFuel);
            if (consumption <= FuelQuantity)
            {
                FuelQuantity -= consumption;
                return $"{GetType().Name} travelled {distance} km";              
            }
            return $"{GetType().Name} needs refueling";
        }

        public virtual void Refuel(double fuel)
        {
           FuelQuantity += fuel;
        }
    }   
}
