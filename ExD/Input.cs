using System;

namespace ExD
{
    internal class Input
    {
        static string word;
        static string translate;

        public static void InputWordTranslate(MyDictionary myDictionary)
        {
            do
            {
                Console.Write("Слово: ");
                word = Console.ReadLine();
                Console.Write("Перевод: ");
                translate = Console.ReadLine();
            } while (myDictionary.Add(word, translate));
        }
    }
}
