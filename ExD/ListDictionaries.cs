using System;
using System.Collections.Generic;

namespace ExD
{
    internal class ListDictionaries
    {
        List<MyDictionary> myDictionaries;

        public ListDictionaries()
        {
            myDictionaries = new List<MyDictionary>();
        }

        public void Print()
        {
            foreach (var dictionary in myDictionaries)
            {
                Console.WriteLine(dictionary.TypeDictionary);
            }
        }
    }
}
