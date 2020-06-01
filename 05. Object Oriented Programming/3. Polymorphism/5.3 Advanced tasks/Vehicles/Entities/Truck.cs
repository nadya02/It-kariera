using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_rightWay.Entities
{
    public class Truck : Vehicle
    {
        private const double IncreaseFuelPerKm = 1.6;
        private const double FuelLeak = 0.95;

        public override string Drive(double distance, double increasedFuel)
        {
            increasedFuel = IncreaseFuelPerKm;
            return base.Drive(distance, increasedFuel);
        }
        public Truck(double fuelQuantity, double fuelPerKm) : base(fuelQuantity, fuelPerKm)
        {
        }

        public override void Refuel(double fuel)
        {
             base.Refuel(fuel * FuelLeak);
        }

        public override string ToString()
        {
            return $"Truck: {FuelQuantity:f2}";
        }
    }
}
