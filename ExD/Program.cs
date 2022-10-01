using System;

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
                new MenuItemMyDictionary("Добавить слово и его перевод", Input.AddWordTranslate),
                new MenuItemPrint("Вывести словарь", dictionary.Print),
                new MenuCategory("Удалить", new MenuItem[]
                {
                    new MenuItemMyDictionary("Удалить слово", Input.DelWord),
                    new MenuItemMyDictionary("Удалить перевод", Input.DelTranslate),
                    new MenuItemPrint("Удалить словарь", dictionary.Del),
                    new MenuBack()
                }),
                new MenuCategory("Заменить", new MenuItem[]
                {
                    new MenuItemMyDictionary("Заменить слово", Input.ReplacementWord),
                    new MenuAction("Заменить перевод", SomeActionMethod),
                    new MenuBack()
                }),
                new MenuBack("Выход")
            });

            Menu menu = new Menu(menuCategory, dictionary);
            menu.Run();
        }
    }
}
