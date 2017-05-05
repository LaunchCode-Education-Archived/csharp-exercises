using System;

namespace Cats
{
    public class HouseCat : Cat
    {
        public string Name { get; set; }

        private string species = "Felis catus";
        public string Species
        {
            get { return species; }
            private set { species = value; }
        }

        public HouseCat(string name, double weight) : base(weight)
        {
            Name = name;
        }

        public bool IsSatisfied()
        {
            return !IsHungry && !IsTired;
        }

        public override void Noise()
        {
            if (IsSatisfied())
            {
                Console.WriteLine("Hello, my name is " + Name + "!");
            }
            else
            {
                //base.Noise();
            }
        }

        public void Purr()
        {
            Console.WriteLine("I'm a HouseCat");
        }
    }
}
