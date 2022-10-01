using System;
using System.Collections.Generic;

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

        public bool Add(string word, string translate)
        {
            bool wordExist = false;

            if (dictionary.ContainsKey(word))
            {
                if (!dictionary[word].Contains(translate))
                {
                    dictionary[word].Add(translate);
                }
                else
                {
                    Console.WriteLine("Слово с таким переводом уже существует. Попробуйте еще раз");
                    wordExist = true;
                }
            }
            else
            {
                dictionary.Add(word, new List<string> { translate });
            }
            return wordExist;
        }

        public void ReplacementTranslete(string word, string translate)
        {
            if (dictionary.ContainsKey(word))
            {
                dictionary.K
            }
            else
            {
                Console.WriteLine("В словаре нет такого слова");
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
