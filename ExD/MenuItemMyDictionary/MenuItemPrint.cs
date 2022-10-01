using System;

namespace ExD
{
    internal class MenuItemPrint : MenuItem
    {
        public Action Action { get; }

        public MenuItemPrint(string name, Action action) : base(name)
        {
            Action = action;
        }
    }
}
