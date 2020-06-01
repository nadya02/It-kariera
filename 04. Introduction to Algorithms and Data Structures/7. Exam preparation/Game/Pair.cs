using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Pair
    {
        private int first;
        private int last;

        public int Last
        {
            get { return last; }
            set { last = value; }
        }

        public int First
        {
            get { return first; }
            set { first = value; }
        }

        public Pair(int first, int last)
        {
            this.First = first;
            this.Last = last;
        }

        public override string ToString()
        {
            return $"({First}, {Last})";
        }

        public int Difference()
        {
            return Math.Abs(first - last);
        }
    }
}
