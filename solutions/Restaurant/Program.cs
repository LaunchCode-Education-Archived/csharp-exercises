using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    public class MenuItem {
        private string name;
        public string Name {
            get {
                return name;
            } 

            set {
                name = value;
            }
        }

        private string description;
        public string Description {
            get {
                return description;
            }
            set {
                description = value;
            }
        }

        private double price;
        public double Price {
            get {
                return price;
            }
            set {
                price = value;
            }
        }

        private string[] categories = new string[] 
        { "appetizer", "main course", "dessert" };

        private string category;
        public string Category {
            get {
                return category;
            }

            set {
                if (!categories.Contains(value)) throw new Exception("No");
                else category = value;
            }
        }

        private bool newItem = true;
        public bool NewItem {
            get {
                return newItem;
            }
            set {
                newItem = value;
            }
        }

        public MenuItem(string name, string description, double price, string category) {
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
                        "{0}{1}: ${2}\n\t\t{3}\n\n", item.NewItem ? "New! " : "", item.Name, item.Price, item.Description
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
