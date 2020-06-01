using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_rightWay.Entities
{
    public class Car : Vehicle
    {
        private const double IncreaseFuelPerKm = 0.9;

        public override string Drive(double distance, double increaseFuel)
        {
            increaseFuel = IncreaseFuelPerKm;
            return base.Drive(distance, increaseFuel);
        }

        public Car(double fuelQuantity, double fuelPerKm) : base(fuelQuantity, fuelPerKm)
        {
        }

        public override string ToString()
        {
            return $"Car: {FuelQuantity:f2}";
        }
    }
}
