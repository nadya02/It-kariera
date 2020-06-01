using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undo_Lists_of_adresses
{
    class UndoListsOfAdresses
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            string input;
            while((input = Console.ReadLine()) != "exit")
            {
                if(input == "back")
                {
                    if(st.Count == 0)
                    {
                        Console.WriteLine("The stack is empty");
                    }
                    else
                    {
                        st.Pop();//изтрива текущия адрес
                        Console.WriteLine(st.Peek());//показва предходния адрес
                    }
                }
                else
                {
                    st.Push(input);
                }
            }
        }
    }
}
