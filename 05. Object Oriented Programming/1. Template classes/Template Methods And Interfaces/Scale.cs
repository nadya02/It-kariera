using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_scales
{
    class Scale<T> where T : IComparable<T>
    {
        private T left;
        private T right;

        public T Right
        {
            get { return right; }
            set { right = value; }
        }

        public T Left
        {
            get { return left; }
            set { left = value; }
        }

        public Scale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public T GetHeavier()
        {
            if (left.CompareTo(right) < 0)
            {
                return right;
            }
            else
            {
                if (left.CompareTo(right) > 0)
                {
                    return left;
                }
                else
                {
                    return default(T);
                }
            }
        }
    }
}
