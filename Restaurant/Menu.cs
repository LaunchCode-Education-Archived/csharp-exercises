using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Menu
    {
        private readonly List<MenuItem> menuItems;
        private DateTime lastUpdated;

        public Menu()
        {
            menuItems = new List<MenuItem>();
            LastUpdated = DateTime.Now;
        }

        public DateTime LastUpdated
        {
            get { return lastUpdated; }
            private set { lastUpdated = value; }
        }

        public MenuItem[] MenuItems
        {
            get
            {
                return menuItems.ToArray();
            }
        }

        public void AddItem(MenuItem item)
        {
            menuItems.Add(item);
            lastUpdated = DateTime.Now;
        }
    }
}
