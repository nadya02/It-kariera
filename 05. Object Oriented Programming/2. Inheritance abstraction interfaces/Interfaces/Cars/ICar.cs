using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    interface ICar
    {
        string Model { get; }
        string Color { get; }

        string Start();
        string Stop();
    }
}
