using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_of_strings
{
    class StackOfStrings_class
    {
        private List<string> data = new List<string>();

        public void Push(string element)
        {
            data.Add(element);
        }

        public string Pop()
        {
            string removedElement = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return removedElement;
        }

        public string Peek()
        {
            string shownElement = data[data.Count - 1];
            return shownElement;
        }

        public bool IsEmpty()
        {
            if(data.Count == 0)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string result = "";
            foreach (var item in data)
            {
                result += item + " ";
            }
            return result;
        }
    }
}
