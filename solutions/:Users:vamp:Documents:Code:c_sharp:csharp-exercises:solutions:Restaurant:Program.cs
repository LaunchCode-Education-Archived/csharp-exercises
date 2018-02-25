using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    public class MenuItem {
        private string name;
        private string description;
        private double price;
        private string category;
        private bool newItem = true;

        private string[] categories = new string[]
        { "appetizer", "main course", "dessert" };


        public string Name {
            get => name;
            set => name = value;
        }

        public string Description {
            get => description;
            set => description = value;
        }

        public double Price {
            get => price;
            set => price = value;
        }

        public string Category {
            get => category;
            set {
                if (!categories.Contains(value))
                    throw new Exception(
                        string.Format("Invalid menu item category {0}", value)
                    );
                else category = value;
            }
        }

        public bool NewItem {
            get => newItem;
            set => newItem = value;
        }

        public MenuItem(
            string name,
            string description,
            double price,
            string category
        ) {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
        }
    }

    class Menu {
        private string updatedAt = DateTime.Now.ToString();
        public string UpdatedAt {
            get => updatedAt;
            set => updatedAt = value;

        }

        public List<MenuItem> Items = new List<MenuItem>();

        private void SetUpdateDate() {
            UpdatedAt = DateTime.Now.ToString(); 
        }

        public void AddItem(MenuItem menuItem) {
            foreach(MenuItem item in this.Items) item.NewItem = false;
            Items.Add(menuItem);
            this.SetUpdateDate();
        }

        public void RemoveItem(string name) {
            Items.RemoveAll(e => e.Name == name);
            this.SetUpdateDate();
        }

        public void PrintItems() {
            Console.WriteLine(string.Format("Last Updated: {0}", this.UpdatedAt));
            foreach(MenuItem item in this.Items) {
                Console.WriteLine(
                    string.Format(
                        "{0}{1}: ${2}\n\t{3}\n\n",
                        item.NewItem ? "New! " : "",
                        item.Name,
                        item.Price,
                        item.Description
                    )
                );
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MenuItem Pizza = new MenuItem("dildo", "baggins", 5.96, "dessert");
            MenuItem CheeseStick = new MenuItem("cheesestick", "nice", 5.96, "dessert");
            Menu NewMenu = new Menu();
            NewMenu.AddItem(Pizza);
            NewMenu.AddItem(CheeseStick);
            NewMenu.PrintItems();
            Console.ReadLine();
        }
    }
}
