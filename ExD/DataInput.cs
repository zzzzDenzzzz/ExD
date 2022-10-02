using System;

namespace ExD
{
    internal class DataInput
    {
        static string word;
        static string translation;
        static string newWord;
        static string newTranslation;

        public static void AddWordTranslation(MyDictionary myDictionary)
        {
            Console.Write("Слово: ");
            word = Console.ReadLine();
            Console.Write("Перевод: ");
            translation = Console.ReadLine();
            myDictionary.Add(word, translation);
        }

        public static void ReplacementWord(MyDictionary myDictionary)
        {
            Console.Write("Слово: ");
            word = Console.ReadLine();
            Console.Write("Новое слово: ");
            newWord = Console.ReadLine();
            myDictionary.ReplacementWord(word, newWord);
        }

        public static void ReplacementTranslation(MyDictionary myDictionary)
        {
            Console.Write("Слово: ");
            word = Console.ReadLine();
            Console.Write("Перевод: ");
            translation = Console.ReadLine();
            Console.Write("Новый перевод: ");
            newTranslation = Console.ReadLine();
            myDictionary.ReplacementTranslation(word, translation, newTranslation);
        }

        public static void DelWord(MyDictionary myDictionary)
        {
            Console.Write("Слово: ");
            word = Console.ReadLine();
            myDictionary.DelWord(word);
        }

        public static void DelTranslatation(MyDictionary myDictionary)
        {
            Console.Write("Слово: ");
            word = Console.ReadLine();
            Console.Write("Перевод: ");
            translation = Console.ReadLine();
            myDictionary.DelTranslation(word, translation);
        }

        public static void SearchTranslation(MyDictionary myDictionary)
        {
            Console.Write("Слово: ");
            word = Console.ReadLine();
            myDictionary.SearchTranslation(word);
        }

        public static void ExportWordToFile(MyDictionary myDictionary)
        {
            Console.Write("Слово: ");
            word = Console.ReadLine();
            myDictionary.ExportWordToFile(word);
        }
    }
}
