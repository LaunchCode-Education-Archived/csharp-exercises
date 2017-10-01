using System;

namespace Class5Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            // How to modulate data...
            Car myCar;

            myCar = new Car();

            myCar.Make = "Oldsmobile";
            myCar.Model = "Chevrolet";
            myCar.Year = 2004;
            myCar.Color = "Blue";

            Console.WriteLine("The make is {0}, the model is {1} the year is {2} and the color is {3}."
                ,myCar.Make
                ,myCar.Model
                ,myCar.Year,
                myCar.Color);

                myCar.Color = "Red";

            Console.WriteLine("The retail price of the car is {0:C}.", DetermineMarketValue(myCar));

            Console.ReadLine();
        }
        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue;
            carValue = 1000M;

            return carValue;
        }   
    }
    // Begin work outside of Class Program, but inside of namespace..
    // We want to create a Car Class to contain all car attributes...
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        //Created a car class with four properties or attributes

        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 1990)
            {
                 carValue = 100M;
            }
            else
            {
                 carValue = 2000M;
            }

            return carValue;
        }
            
        
    }
}
