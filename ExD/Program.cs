using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExD
{
    internal class Program
    {
        private static void SomeActionMethod(MenuItem menuItem)
        {
            Console.WriteLine($"Вы нажали: {menuItem.Name}");
        }

        static void Main(string[] args)
        {
            var dictionary = new MyDictionary("e - r");

            MenuCategory menuCategory = new MenuCategory("Главное меню", new MenuItem[]
            {
                new MenuItemAdd("Добавить слово и его перевод", Input.InputWordTranslate),
                new MenuItemPrint("Вывести словарь", dictionary.Print),
                new MenuAction("Пункт 2", SomeActionMethod),
                new MenuAction("Пункт 3", SomeActionMethod),
                new MenuCategory("Подменю 1", new MenuItem[]
                {
                    new MenuAction("Пункт 1.1", SomeActionMethod),
                    new MenuAction("Пункт 1.2", SomeActionMethod),
                    new MenuAction("Пункт 1.3", SomeActionMethod),
                    new MenuBack()
                }),
                new MenuCategory("Подменю 2", new MenuItem[]
                {
                    new MenuAction("Пункт 2.1", SomeActionMethod),
                    new MenuAction("Пункт 2.2", SomeActionMethod),
                    new MenuBack()
                }),
                new MenuBack("Выход")
            });

            Menu menu = new Menu(menuCategory, dictionary);
            menu.Run();
        }
    }
}
