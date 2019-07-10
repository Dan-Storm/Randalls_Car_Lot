using System;
using System.Collections.Generic;


namespace Randalls_car_lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var modelT = new Dictionary<string, string>
            {
                {"Year", "1914"},
                {"Make", "Ford"},
                {"Model", "T"},
                {"Price", "300"}
            };

            var modelX = new Dictionary<string, string>
            {
                {"Year", "2017"},
                {"Make", "Tesla"},
                {"Model", "X"},
                {"Price", "90000"}
            };

            var garage = new List<Dictionary<string, string>>();
            garage.Add(modelT);
            garage.Add(modelX);

            var delorean = new Car();
            delorean.Year = 2017;
            delorean.Model = "delorean";
            delorean.Make = "delorean";
            delorean.Price = 78000.23;

            var ford = new Car()
            {
            Year = 2017,
            Model = "fiesta",
            Make = "ford",
            Price = 18000.23,
            };

        }
    }

    class Car
    {
        public int Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public double Price { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{Make}: I'm drivin' here!!!");
        }
    }
}
