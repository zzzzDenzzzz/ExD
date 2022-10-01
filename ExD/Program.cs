namespace ExD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new MyDictionary("e - r");

            MenuCategory menuCategory = new MenuCategory("Главное меню", new MenuItem[]
            {
                new MenuItemMyDictionary("Добавить слово или его перевод", Input.AddWordTranslation),
                new MenuItemMyDictionary("Искать перевод", Input.SearchTranslation),
                new MenuItemPrintDel("Вывести словарь", dictionary.Print),
                new MenuCategory("Удалить", new MenuItem[]
                {
                    new MenuItemMyDictionary("Удалить слово", Input.DelWord),
                    new MenuItemMyDictionary("Удалить перевод", Input.DelTranslatation),
                    new MenuItemPrintDel("Удалить словарь", dictionary.Del),
                    new MenuBack()
                }),
                new MenuCategory("Заменить", new MenuItem[]
                {
                    new MenuItemMyDictionary("Заменить слово", Input.ReplacementWord),
                    new MenuItemMyDictionary("Заменить перевод", Input.ReplacementTranslation),
                    new MenuBack()
                }),
                new MenuBack("Выход")
            });

            Menu menu = new Menu(menuCategory, dictionary);
            menu.Run();
        }
    }
}
