using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_rightWay.Interfaces
{
    public interface IVehicle : IRefuable, IDrivable
    {
        double FuelPerKm { get; }
        double FuelQuantity { get; }
    }
}
