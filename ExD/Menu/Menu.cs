using System;
using System.Collections.Generic;

namespace ExD
{
    internal class Menu
    {
        MenuCategory current;
        MyDictionary myDictionary;

        public Menu(MenuCategory root)
        {
            current = root;
            myDictionary = new MyDictionary();
        }

        void SetOfMethods()
        {
            Console.ResetColor();
            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadLine();
            Console.Clear();
        }

        public void Run()
        {
            Stack<MenuCategory> wayBack = new Stack<MenuCategory>();
            int index = 0;
            while (true)
            {
                DrawMenu(0, 0, index);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < current.Items.Length - 1)
                        {
                            index++;
                        }
                        else
                        { 
                            index = 0;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                        {
                            index--;
                        }
                        else
                        { 
                            index = current.Items.Length - 1;
                        }
                        break;
                    case ConsoleKey.Enter:
                        switch (current.Items[index])
                        {
                            case MenuCategory category:
                                wayBack.Push(current);
                                index = 0;
                                current = category;
                                Console.Clear();
                                break;
                            case MenuItemMyDictionary menuMyDictionary:
                                menuMyDictionary.Action(myDictionary);
                                SetOfMethods();
                                break;
                            case MenuBack _:
                                if (wayBack.Count == 0)
                                {
                                    myDictionary.SaveDictionaryToFile();
                                    return;
                                }
                                MenuCategory parent = wayBack.Pop();
                                index = Array.IndexOf(parent.Items, current);
                                current = parent;
                                Console.Clear();
                                break;
                            default:
                                throw new InvalidCastException("Неизвестный тип пункта меню");
                        }
                        break;
                }
            }
        }

        private void DrawMenu(int row, int col, int index)
        {
            Console.SetCursorPosition(col, row);
            Console.WriteLine(current.Name);
            Console.WriteLine();

            for (int i = 0; i < current.Items.Length; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(current.Items[i].Name);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
