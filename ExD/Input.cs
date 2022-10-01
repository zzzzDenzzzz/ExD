using System;

namespace ExD
{
    internal class Input
    {
        static string word;
        static string translate;

        public static void AddWordTranslate(MyDictionary myDictionary)
        {
            Console.Write("Слово: ");
            word = Console.ReadLine();
            Console.Write("Перевод: ");
            translate = Console.ReadLine();
            myDictionary.Add(word, translate);
        }

        public static void ReplacementWord(MyDictionary myDictionary)
        {
            Console.Write("Слово: ");
            word = Console.ReadLine();
            Console.Write("Новое слово: ");
            translate = Console.ReadLine();
            myDictionary.ReplacementWord(word, translate);
        }

        public static void DelWord(MyDictionary myDictionary)
        {
            Console.Write("Слово: ");
            word = Console.ReadLine();
            myDictionary.DelWord(word);
        }

        public static void DelTranslate(MyDictionary myDictionary)
        {
            Console.Write("Слово: ");
            word = Console.ReadLine();
            Console.Write("Перевод: ");
            translate = Console.ReadLine();
            myDictionary.DelTranslate(word, translate);
        }
    }
}
