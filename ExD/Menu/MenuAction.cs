using System;

namespace ExD
{
    internal class MenuAction : MenuItem
    {
        public Action<MenuItem> Action { get; }

        public MenuAction(string name, Action<MenuItem> action) : base(name)
        {
            Action = action;
        }
    }
}
