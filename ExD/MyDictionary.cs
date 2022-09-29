using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExD
{
    internal class MyDictionary
    {
        public string TypeDictionary { get; }
        SortedList<string, List<string>> dictionary;

        public MyDictionary(string typeDictionary)
        {
            TypeDictionary = typeDictionary;
            dictionary = new SortedList<string, List<string>>() { };
        }

        public static MyDictionary CreateDictionary(string typeDictionary)
        {
            return new MyDictionary(typeDictionary);
        }

        public void Add(string word, string translate)
        {
            if (dictionary.ContainsKey(word))
            {
                if (!dictionary[word].Contains(translate))
                {
                    dictionary[word].Add(translate);
                }
                else
                {
                    throw new ArgumentException("error: class MyDictionary->Add->if->if()");
                }
            }
            else
            {
                dictionary.Add(word, new List<string> { translate });
            }
        }

        public void Print()
        {
            foreach (var itemKey in dictionary)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(itemKey.Key);
                foreach (var itemValue in itemKey.Value)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(itemValue);
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
