using System.Globalization;

namespace BonusLab17
{
    internal class UsedCar : Car
    {
        public double milagea;

        public double Milagea { get => milagea; set => milagea = value; }



        public UsedCar(string make, string model, int year, double price, double milagea) :

            base(make, model, year, price)
        {
            this.milagea = milagea;

        }
        public override string ToString()
        {
            return $"{Make}\t {Model} \t{Year}\t{Price.ToString("C2", CultureInfo.CurrentCulture)}(used){milagea} Miles";
        }

        public UsedCar()
        {
        }


    }
}
