namespace ExD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new MyDictionary("e - r");

            MenuCategory menuCategory = new MenuCategory("Главное меню", new MenuItem[]
            {
                new MenuItemMyDictionary("Создать словарь", DataInput.AddWordTranslation),
                new MenuItemMyDictionary("Выбрать словарь", DataInput.AddWordTranslation),
                new MenuCategory("Работа со словарем", new MenuItem[]
                {
                    new MenuItemMyDictionary("Добавить слово или его перевод", DataInput.AddWordTranslation),
                    new MenuItemMyDictionary("Искать перевод", DataInput.SearchTranslation),
                    new MenuItemMyDictionary("Экспорт слова в файл", DataInput.ExportWordToFile),
                    new MenuItemPrintDel("Вывести словарь", dictionary.Print),
                    new MenuCategory("Удалить", new MenuItem[]
                    {
                        new MenuItemMyDictionary("Удалить слово", DataInput.DelWord),
                        new MenuItemMyDictionary("Удалить перевод", DataInput.DelTranslatation),
                        new MenuItemPrintDel("Удалить словарь", dictionary.Del),
                        new MenuBack()
                    }),
                    new MenuCategory("Заменить", new MenuItem[]
                    {
                        new MenuItemMyDictionary("Заменить слово", DataInput.ReplacementWord),
                        new MenuItemMyDictionary("Заменить перевод", DataInput.ReplacementTranslation),
                        new MenuBack()
                    }),
                    new MenuBack()
                }),
                new MenuBack("Выход")
            });

            Menu menu = new Menu(menuCategory, dictionary);
            menu.Run();
        }
    }
}
