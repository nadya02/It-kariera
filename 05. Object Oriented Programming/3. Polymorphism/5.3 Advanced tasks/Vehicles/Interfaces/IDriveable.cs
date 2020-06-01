using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_rightWay.Interfaces
{
    public interface IDrivable
    {
        string Drive(double distance, double IncreasedFuel);
    }
}
