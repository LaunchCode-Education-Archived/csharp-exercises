using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != typeof(MenuItem))
                return false;
            return Equals((MenuItem)obj);
        }

        public bool Equals(MenuItem menuItem)
        {
            if (menuItem == null)
                return false;
            return menuItem.Name == this.Name;
        }


        public static void Print(MenuItem menu)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode(MenuItem menuItem)
        {
            return menuItem.Name.GetHashCode();
        }

        private DateTime dateAddedToMenu;
        public DateTime DateAddedToMenu
        {
            get { return dateAddedToMenu; }
            set { dateAddedToMenu = value; }
        }
    }
}
