using System;

namespace ExD
{
    internal class MenuItemPrintDel : MenuItem
    {
        public Action Action { get; }

        public MenuItemPrintDel(string name, Action action) : base(name)
        {
            Action = action;
        }
    }
}
