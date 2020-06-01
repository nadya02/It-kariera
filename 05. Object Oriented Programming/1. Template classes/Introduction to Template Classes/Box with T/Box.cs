using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_with_T
{
    class Box<T>
    {
        private Stack<T> box = new Stack<T>();
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public void Add(T element)
        {
            box.Push(element);
            count++;
        }

        public T Remove()
        {
            T removedElement = box.Peek();
            box.Pop();
            count--;
            return removedElement;
        }


    }
}
