using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Menu
    {
        public List<MenuItem> Items
        {
            get { return Items; }
            private set { Items = value; }
        }
        public DateTime LastUpdated
        {
            get { return LastUpdated; }
            private set { LastUpdated = value; }
        }

        public Menu()
        {
            Items = new List<MenuItem>();
        }

        public void AddItem(MenuItem item)
        {

        }
    }
}
