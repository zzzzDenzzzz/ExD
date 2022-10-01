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

        void ColorMessage(ConsoleColor background, ConsoleColor foreground)
        {
            Console.BackgroundColor = background;
            Console.ForegroundColor = foreground;
        }

        public void Add(string word, string translation)
        {
            if (dictionary.ContainsKey(word))
            {
                if (!dictionary[word].Contains(translation))
                {
                    dictionary[word].Add(translation);
                    ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Yellow);
                    Console.WriteLine($"Перевод [{translation}] слова [{word}] добавлен");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Red);
                    Console.WriteLine($"Слово [{word}] с переводом [{translation}] уже существует");
                }
            }
            else
            {
                dictionary.Add(word, new List<string> { translation });
                ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Green);
                Console.WriteLine($"Слово [{word}] с переводом [{translation}] добавлено");
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
                    ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Green);
                    Console.WriteLine($"Слово [{word}] заменено на [{newWord}]");
                }
                else
                {
                    ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Red);
                    Console.WriteLine($"Слово [{newWord}] уже есть в словаре");
                }
            }
            else
            {
                ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Yellow);
                Console.WriteLine($"В словаре нет слова [{word}]");
            }
        }

        public void ReplacementTranslation(string word, string translation, string newTranslation)
        {
            if (dictionary.ContainsKey(word))
            {
                if (dictionary[word].Contains(translation))
                {
                    dictionary[word].Remove(translation);
                    dictionary[word].Add(newTranslation);
                    ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Green);
                    Console.WriteLine($"Вариант перевода [{translation}] слова [{word}] заменен на перевод [{newTranslation}]");
                }
                else
                {
                    ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Yellow);
                    Console.WriteLine($"В словаре нет перевода [{translation}] для слова [{word}]");
                }
            }
            else
            {
                ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Red);
                Console.WriteLine($"В словаре нет слова [{word}]");
            }
        }

        public void DelWord(string word)
        {
            if (dictionary.ContainsKey(word))
            {
                dictionary.Remove(word);
                ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Green);
                Console.WriteLine($"Слово [{word}] удалено");
            }
            else
            {
                ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Red);
                Console.WriteLine($"В словаре нет слова [{word}]");
            }
        }

        public void DelTranslation(string word, string translation)
        {
            if (dictionary.ContainsKey(word))
            {
                if (dictionary[word].Contains(translation))
                {
                    if (dictionary[word].Count > 1)
                    {
                        dictionary[word].Remove(translation);
                        ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Green);
                        Console.WriteLine($"Перевод [{translation}] слова [{word}] удален");
                    }
                    else
                    {
                        ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Yellow);
                        Console.WriteLine($"Перевод [{translation}] слова [{word}] удалить невозможно, т.к. это последний вариант перевода");
                    }
                }
                else
                {
                    ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Red);
                    Console.WriteLine($"В словаре нет перевода [{translation}] для слова [{word}]");
                }
            }
            else
            {
                ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Red);
                Console.WriteLine($"В словаре нет слова [{word}]");
            }
        }

        public void SearchTranslation(string word)
        {
            if (dictionary.ContainsKey(word))
            {
                ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Gray);

                foreach (var item in dictionary[word])
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
            else
            {
                ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Red);
                Console.WriteLine($"В словаре нет слова [{word}]");
            }
        }

        public void Del()
        {
            dictionary.Clear();
            ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Green);
            Console.WriteLine($"Словарь {TypeDictionary} удален");
        }

        public void Print()
        {
            foreach (var itemKey in dictionary)
            {
                ColorMessage(background: ConsoleColor.Black, foreground: ConsoleColor.Red);
                Console.WriteLine(itemKey.Key);
                foreach (var itemValue in itemKey.Value)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(itemValue);
                }
                Console.WriteLine();
            }
        }
    }
}
