using System;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    class ListyIterator_class<T>
    {
        private int index = 0;
        private List<T> listy;

        public ListyIterator_class(params T[] listy)
        {
            this.Create();
        }

        public void Create(params T[] listy)
        {
            this.listy = new List<T>(listy);
        }

        public bool Move()
        {
            if(HasNext() == true)
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasNext()
        {
            if(this.index + 1 > this.listy.Count - 1)
            {
                return false;
            }
            else
            {
                return true;
            }                
        }

        public void Print()
        {
            if(this.listy.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(this.listy[this.index].ToString());
            }
        }
    }
}
