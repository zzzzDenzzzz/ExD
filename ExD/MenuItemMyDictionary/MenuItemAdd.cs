using System;

namespace ExD
{
    internal class MenuItemAdd : MenuItem
    {
        public Action<MyDictionary> Action { get; }

        public MenuItemAdd(string name, Action<MyDictionary> action) : base(name)
        {
            Action = action;
        }
    }
}
