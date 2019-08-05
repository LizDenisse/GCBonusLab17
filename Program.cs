using System;
using System.Collections.Generic;

namespace BonusLab17
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Car> cars = Inventory();

            int i = 1;
            foreach (var s in cars)
            {
                Console.WriteLine(i + "." + s);
                i++;
            }
            Console.WriteLine("{0}. Exit", cars.Count + 1);

            bool repeatProgram = true;
            while (repeatProgram)
            {
                Console.WriteLine("Which Car Would you like?");

                string a = Console.ReadLine();
                int b = 0;
                try
                {
                    b = int.Parse(a);

                }
                catch (Exception)
                {
                    Console.WriteLine("invalid entry");
                    a = Console.ReadLine();
                    b = int.Parse(a);
                }
                if (b == cars.Count + 1)
                {
                    Console.WriteLine("Good Bye");
                    break;
                }
                Console.WriteLine("You have selected {0}", cars[b - 1]);
                Console.WriteLine("Do you which to buy this car?");
                string ans = Console.ReadLine().ToLower();
                while (ans != "n" && ans != "y")
                {
                    Console.WriteLine("Invalid Entry, Enter y/n");
                    ans = Console.ReadLine();
                }
                if (ans == "y")
                {
                    Console.WriteLine("Exellent!! Our Finance Team will contact you shortly");
                    cars.RemoveAt(b - 1);

                    i = 1;
                    foreach (var s in cars)
                    {
                        Console.WriteLine(i + "." + s);
                        i++;
                    }
                    Console.WriteLine("{0}. Exit", cars.Count + 1);

                }
            }
        }

        static public List<Car> Inventory()
        {
            Car car1 = new Car()
            {
                make = "Nicolai\t",
                model = "Model S \t",
                year = 2019,
                price = 54999.90
            };
            Car car2 = new Car()
            {
                make = "Fourd\t",
                model = "Escapade   \t ",
                year = 2019,
                price = 31999.90
            };
            Car car3 = new Car()
            {
                make = "Chewie\t",
                model = "Vette\t",
                year = 2019,
                price = 44989.95
            };
            Car car4 = new UsedCar()
            {
                make = "Hynonda\t",
                model = "Prior\t",
                year = 2005,
                price = 14795.50,
                milagea = 35987.6
            };
            Car car5 = new UsedCar()
            {
                make = "GC\t",
                model = "Chirpus\t",
                year = 2013,
                price = 8500.00,
                milagea = 12345.0
            };
            Car car6 = new UsedCar()
            {
                make = "GC\t",
                model = "whitherell\t",
                year = 2016,
                price = 14450.00,
                Milagea = 3500.3
            };

            List<Car> cars = new List<Car>(6);

            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);
            cars.Add(car5);
            cars.Add(car6);

            return cars;

        }
    }
}

