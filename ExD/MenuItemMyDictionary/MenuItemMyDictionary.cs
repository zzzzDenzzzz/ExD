using System;

namespace ExD
{
    internal class MenuItemMyDictionary : MenuItem
    {
        public Action<MyDictionary> Action { get; }

        public MenuItemMyDictionary(string name, Action<MyDictionary> action) : base(name)
        {
            Action = action;
        }
    }
}
