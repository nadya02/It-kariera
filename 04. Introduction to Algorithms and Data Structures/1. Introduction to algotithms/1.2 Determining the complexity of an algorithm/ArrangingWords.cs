using System;
using System.Linq;

namespace Arranging_words
{
    class ArrangingWords
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToList();
            for (int i = 0; i < words.Count - 1; i++)
            {
                int index = 1;
                string minWord = words[i];
                for (int j = i+1; j < words.Count; j++)
                {
                    if(words[j].CompareTo(minWord) < 0)
                    {
                        minWord = words[j];
                        index = j;
                    }
                }
                string temp = words[i];
                words[i] = words[index];
                words[index] = temp;
            }
            Console.WriteLine(string.Join(" ",words));
        }
    }
}
