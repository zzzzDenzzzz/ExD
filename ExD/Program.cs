using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new MyDictionary("e - r");
            var d1 = MyDictionary.CreateDictionary("r - e");
            try
            {
                d.Add("word2", "перевод0");
                d.Add("word1", "перевод0");
                d.Add("word0", "перевод0");
                d.Add("word0", "перевод1");
                d.Add("word2", "перевод1");
                d.Print();

                d1.Add("слово2", "translete0");
                d1.Add("слово1", "translete0");
                d1.Add("слово0", "translete0");
                d1.Add("слово0", "translete1");
                d1.Add("слово2", "translete1");
                d1.Print();
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }
    }
}
