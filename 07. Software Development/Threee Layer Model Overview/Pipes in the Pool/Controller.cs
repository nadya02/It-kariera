using Pipes_in_the_Pool.Model;
using Pipes_in_the_Pool.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pipes_in_the_Pool.Controllers
{
    class Controller
    {
        private Display display;
        private Pool pool;
        public Controller()
        {
            display = new Display();
            pool = new Pool(display.Volume, display.FlowRate1, display.FlowRate2, display.WorkingHours);
            display.Result = pool.GetResult();
            display.Show();
        }
    }
}
