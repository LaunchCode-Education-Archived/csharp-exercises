using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Tesla", "M-Class", 2, 3.0, "brown");
            Car car1 = new Car("Tesla", "M-Class", 3.0, "brown");

            car1.Start();

            Console.WriteLine();

            Console.ReadLine();
        }


    }

    public class Car
    {
        private string brand, model;
        private int door;

        public double Engine { get; set; }
        public string Color { get; set; }
        public bool Ignition { get; set; }

        public Car(string brand, string model, int doors, double engine, string color)
        {
            this.brand = brand;
            this.model = model;
            this.doors = doors;
            this.Engine = engine;
            this.Color = color;

            //Defaults
            this.year = DateTime.Now;
            this.Ignition = false;

        }

        public Car( string brand, string model, double engine)
            :this(brand, model){}
        
        public void Start()
        {
        Console.WriteLine("VROOM/nVROOM");
        this.Ignition = true;
        }
        public void TurnOff()
        {
        Console.WriteLine();
        }
        public void Forward(double miles)
        {
            if(this.ignition)
            {
                Console.WriteLine();
                milesTraveled = miles;
            }
            else
            {
            Console.WriteLine("Car is not on, it can't move forward");
            }
        }
    }
}
