using System;

namespace Temperature
{
    public class Temperature
    {

        private double fahrenheit;

        public double Fahrenheit
        {
            get
            {
                return fahrenheit;
            }
            set
            {
                double absoluteZeroFahrenheit = -459.67;

                if (value < absoluteZeroFahrenheit)
                {
                    throw new ArgumentException("Value is below absolute zero");
                }

                fahrenheit = value;
            }
        }

        public double Celsius
        {
            get { return (Fahrenheit - 32) * 5.0 / 9.0; }
            set { Fahrenheit = value * 9.0 / 5.0 + 32; }
        }
    }
}
