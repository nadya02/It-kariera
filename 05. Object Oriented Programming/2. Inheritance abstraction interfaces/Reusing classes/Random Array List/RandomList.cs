using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Array_List
{
    class RandomList : ArrayList
    {
        private Random rnd = new Random();

        public object RandomElement()
        {
            int index = rnd.Next(0, base.Count - 1);
            object element = base[index];
            base.Remove(element);
            return element;
        }

    }
}
