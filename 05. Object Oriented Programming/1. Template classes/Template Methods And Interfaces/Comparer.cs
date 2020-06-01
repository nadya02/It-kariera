using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_template_method_for_counting_strings
{
    public static class Comparer
    {
        public static int CountBigger<T>( List<T> a, T b ) where T : IComparable<T>
        {
            int count = 0;
            foreach (var item in a)
            {
                if(item.CompareTo(b) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
