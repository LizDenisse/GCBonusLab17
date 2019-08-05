
using System.Globalization;

namespace BonusLab17
{
    internal class Car
    {
        public string make;
        public string model;
        public int year;
        public double price;

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = (int)value; }

        public Car(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }
        public override string ToString()
        {
            return $"{Make} {Model} \t{Year} \t{Price.ToString("C2", CultureInfo.CurrentCulture)}";
        }
        public Car()
        {
        }
    }

}
