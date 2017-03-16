using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant
{
    public class MenuItem
    {
        private decimal price;
        private string description;
        private string category;
        private bool isNew;

        private static readonly string[] categories = new string[] { "appetizer", "main course", "dessert" }; 

        public MenuItem(string description, decimal price, string category, bool isNew)
        {
            Description = description;
            Price = price;
            Category = category;
            IsNew = isNew;
        }

        public decimal Price
        {
            get { return price; }
            private set { price = value; }
        }

        public string Description
        {
            get { return description; }
            private set { description = value; }
        }

        public string Category
        {
            get { return category; }
            private set
            {
                if (!categories.Contains(value))
                {
                    return;
                }
                category = value;
            }
        }

        public bool IsNew
        {
            get { return isNew; }
            private set { isNew = value; }
        }
    }
}
