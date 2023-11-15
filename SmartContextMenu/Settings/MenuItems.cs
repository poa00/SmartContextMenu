﻿using System.Collections.Generic;
using System.Linq;
using SmartContextMenu.Extensions;

namespace SmartContextMenu.Settings
{
    public class MenuItems
    {
        public IList<WindowSizeMenuItem> WindowSizeItems { get; set; }

        public IList<StartProgramMenuItem> StartProgramItems { get; set; }

        public IList<MenuItem> Items { get; set; }

        public MenuItems()
        {
            WindowSizeItems = new List<WindowSizeMenuItem>();
            StartProgramItems = new List<StartProgramMenuItem>();
            Items = new List<MenuItem>();
        }

        public string GetHotKeysCombination(string name)
        {
            var item = Items.Flatten(x => x.Items).Where(x => x.Type == MenuItemType.Item).FirstOrDefault(x => x.Name == name);
            var value = item == null ? "" : item.ToString();
            return value;
        }
    }
}
