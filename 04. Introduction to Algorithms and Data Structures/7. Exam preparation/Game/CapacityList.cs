using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class CapacityList
    {
        private const int InitialCapacity = 2;
        private Pair[] items;

        private int startIndex = 0; //показва първият индекс, от който започваме да сумираме текущите елементи
        private int nextIndex = 0; //показва поредният индекс, на който можем да поставим елемент

        public CapacityList(int capacity = InitialCapacity)
        {
            this.items = new Pair[capacity];
        }

        public int Count
        {
            get;
            private set;
        }

        public Pair SumIntervalPairs()
        {
            Pair result = new Pair(0, 0);
            for (int i = startIndex; i < nextIndex; i++)
            {
                result.First = result.First + items[i].First;
                result.Last = result.Last + items[i].Last;
            }
            return result;
            //TODO: сумирайте двойките от startIndex до nextIndex
        }

        public Pair Sum()
        {
            Pair result = new Pair(0, 0);
            for (int i = 0; i < this.Count; i++)
            {
                result.First = result.First + items[i].First;
                result.Last = result.Last + items[i].Last;
            }
            return result;
            //TODO: сумирайте двойките от 0 до this.Count – всички двойки, които имат право да участват в класирането
        }

        public void Add(Pair item)
        {
            if(nextIndex == items.Length)
            {
                items[startIndex] = SumIntervalPairs();
                startIndex++;
                nextIndex = startIndex;
                Count++;
            }
            items[nextIndex] = item;
            nextIndex++;
            //TODO: Добавяне на двойката         
        }

        public void PrintCurrentState()
        {
            for (int i = 0; i < nextIndex; i++)
            {
                Console.WriteLine(items[i].ToString());
            }
            //TODO: отпечатайте всички двойки от 0 до nextIndex
        }

    }
}
