using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_List
{
    class ReversedList<T>:IEnumerable<T>
    {
        T[] array;
        private const int default_capacity = 2;

        private int count;

        public int Count
        {
            get;
            private set;
        }

        public int Capacity
        {
            get;
            private set;
        }

        public ReversedList(int capacity = default_capacity)
        {
            array = new T[capacity];
            count = 0;
            Capacity = capacity;
        }

        public void Add(T item)
        {
            if (Count == Capacity)
            {
                Array.Resize(ref array, Capacity * 2);
                Capacity = Capacity * 2;
            }
            array[Count] = item;
            Count++;
        }

        public T this[int index]
        {
            get
            {
                if(index >= Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return array[Count - index - 1];
            }
            set
            {
                array[index] = value;
            }
        }

        public T RemoveAt(int index)
        {
            T element = this[index];
            for (int i = Count - index - 1; i < Count - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Count--;
            if(Count < Capacity / 4)
            {
                Array.Resize(ref array, Capacity / 2);
                Capacity = Capacity / 2;
            }
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return this[i];//позволява след връщането на дадения елемент дая се върне отново към цикъла
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
