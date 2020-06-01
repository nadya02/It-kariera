using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy_template
{
    class NameComaprator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = x.Name.Length.CompareTo(y.Name.Length);
            if(result == 0)
            {
                result = x.Name.ToLower().First().CompareTo(y.Name.ToLower().First());
                return result;
            }
            return result;
        }
    }
}
