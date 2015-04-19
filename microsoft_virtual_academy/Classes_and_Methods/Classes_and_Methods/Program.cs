using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();
            myNewCar.Make = "Volkswagen";
            myNewCar.Model = "Passat";
            myNewCar.Year = 1999;
            myNewCar.Color = "Blue";

            Console.WriteLine("{0}, {1}, {2}",
                myNewCar.Make,
                myNewCar.Model, 
                myNewCar.Color);

            //double marketValueOfCar = determineMarketValue(myNewCar);

            Console.WriteLine("Car's value: {0:C}", myNewCar.DetermineMarketValue());

            Console.ReadLine();
        }
        private static double determineMarketValue(Car _car)
        {
            double carValue = 100.0;

            return carValue;
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public double DetermineMarketValue()
        {
            double carValue = 100.0;

            if (this.Year > 1990)
                carValue = 10000.0;
            else
                carValue = 2000.0;

            return carValue;
        }
    }


}
