using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storage
{
    class DistributionCenter : Storage
    {
        public DistributionCenter(string name, IEnumerable<Vehicle> Vehicles) : base(name, 2, 5, new Vehicle[] { new Van(), new Van(), new Van()})
        {
        }
    }
}
