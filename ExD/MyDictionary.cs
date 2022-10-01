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
                    Console.WriteLine($"Слово [{word}] с переводом [{translate}] уже существует");
                }
            }
            else
            {
                dictionary.Add(word, new List<string> { translate });
            }
        }

        public void ReplacementWord(string word, string newWord)
        {
            if (dictionary.ContainsKey(word))
            {
                if (!dictionary.ContainsKey(newWord))
                {
                    List<string> tmpList = dictionary[word];
                    dictionary.Remove(word);
                    dictionary.Add(newWord, tmpList);
                }
                else
                {
                    Console.WriteLine($"Слово [{newWord}] уже есть в словаре");
                }
            }
            else
            {
                Console.WriteLine($"В словаре нет слова {word}");
            }
        }

        //public void ReplacementTranslete(string word, string translate)
        //{
        //    if (dictionary.ContainsKey(word))
        //    {
        //        if (!dictionary[word].Contains(translate))
        //        {

        //        }
        //        else
        //        {
        //            Console.WriteLine("Перевод уже существует");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("В словаре нет такого слова");
        //    }
        //}

        public void DelWord(string word)
        {
            if (dictionary.ContainsKey(word))
            {
                dictionary.Remove(word);
                Console.WriteLine($"Слово {word} удалено");
            }
            else
            {
                Console.WriteLine($"В словаре нет слова {word}");
            }
        }

        public void DelTranslate(string word, string translate)
        {
            if (dictionary.ContainsKey(word))
            {
                if (dictionary[word].Contains(translate))
                {
                    if (dictionary[word].Count > 1)
                    {
                        dictionary[word].Remove(translate);
                        Console.WriteLine($"Перевод [{translate}] слова {word} удален");
                    }
                    else
                    {
                        Console.WriteLine($"Перевод [{translate}] слова {word} удалить невозможно, т.к. это последний вариант перевода");
                    }
                }
                else
                {
                    Console.WriteLine($"В словаре нет перевода [{translate}] для слова [{word}]");
                }
            }
            else
            {
                Console.WriteLine($"В словаре нет слова {word}");
            }
        }

        public void Del()
        {
            dictionary.Clear();
            Console.WriteLine($"Словарь {TypeDictionary} удален");
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
