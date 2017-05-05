using System;

namespace Cats
{
    public abstract class Cat : IFeedable
    {
        public int Age { get; set; }
        public bool IsTired { get; set; } = true;
        public bool IsHungry { get; set; } = true;
        public double Weight { get; set; }

        private string family = "Felidae";
        public string Family
        {
            get { return family; }
            private set { family = value; }
        }

        public Cat(double weight)
        {
            Weight = weight;
        }

        // A cat is rested and hungry after it sleeps
        public void Sleep()
        {
            IsTired = false;
            IsHungry = true;
        }

        // Eating makes a cat not hungry
        public void Eat()
        {

            // eating when not hungry makes a cat sleepy
            if (!IsHungry)
            {
                IsTired = true;
            }

            IsHungry = false;
        }

        public abstract void Noise();
    }
}
