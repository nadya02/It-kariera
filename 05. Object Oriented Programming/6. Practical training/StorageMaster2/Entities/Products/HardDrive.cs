using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Products
{
    class HardDrive : Product
    {
        private const double weight = 1;
        public HardDrive(double price) : base(price, weight)
        {
        }
    }
}
