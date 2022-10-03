namespace ExD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuCategory menuCategory = new MenuCategory("Главное меню", new MenuItem[]
            {
                new MenuItemMyDictionary("Создать словарь", DataInput.CreateDictionary),
                new MenuItemMyDictionary("Загрузить словарь", DataInput.DownloadDictionary),
                new MenuCategory("Работа со словарем", new MenuItem[]
                {
                    new MenuItemMyDictionary("Добавить слово или его перевод", DataInput.AddWordTranslation),
                    new MenuItemMyDictionary("Искать перевод", DataInput.SearchTranslation),
                    new MenuItemMyDictionary("Экспорт слова в файл", DataInput.ExportWordToFile),
                    new MenuItemMyDictionary("Вывести словарь", DataInput.Print),
                    new MenuCategory("Удалить", new MenuItem[]
                    {
                        new MenuItemMyDictionary("Удалить слово", DataInput.DelWord),
                        new MenuItemMyDictionary("Удалить перевод", DataInput.DelTranslatation),
                        new MenuItemMyDictionary("Очистить словарь", DataInput.Clear),
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

            Menu menu = new Menu(menuCategory);
            menu.Run();
        }
    }
}
