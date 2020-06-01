using StorageMaster.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster
{
    class Gpu : Product
    {
        private const double weight = 0.7;
        public Gpu(double price) : base(price, weight)
        {
        }
    }
}
