using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_template
{
    class AgeComparer : Comparer<Person>
    {
        public override int Compare(Person x, Person y)
        {
            int result = x.Age.CompareTo(y.Age);
            return result;
        }
    }
}
