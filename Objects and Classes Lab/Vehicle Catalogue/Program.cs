using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Truck
    {
        public string Brand;
        public string Model;
        public double Weight;
    }
    class Car
    {
        public string Brand;
        public string Model;
        public double HorsePower;
    }
    class Catalog
    {
        public List<Truck> Trucks;
        public List<Car> Cars;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Truck> TrucksList = new List<Truck>();
            List<Car> CarsList = new List<Car>();

            string input = Console.ReadLine();

            while (input != "end")
            {
               
                string type = input.Split("/")[0];
                string brand = input.Split("/")[1];
                string model = input.Split("/")[2];

                if (type == "Car")
                {
                    Car newCar = new Car();
                    double horsePower = double.Parse(input.Split("/")[3]);
                    newCar.Brand = brand;
                    newCar.Model = model;
                    newCar.HorsePower = horsePower;
                    CarsList.Add(newCar);

                }
                else
                {
                    Truck newTruck = new Truck();
                    string weight = input.Split("/")[3];
                    newTruck.Brand = brand;
                    newTruck.Model = model;
                    newTruck.Weight = double.Parse(weight);
                    TrucksList.Add(newTruck);

                }
                input = Console.ReadLine();
            }
            List<Car> OrderedCars = CarsList.OrderBy(car => car.Brand).ToList();
            List<Truck> OrderedTrucks = TrucksList.OrderBy(truck=>truck.Brand).ToList();
            Console.WriteLine("Cars:");
            foreach (var newCar in OrderedCars)
            {
                Console.WriteLine($"{newCar.Brand}: {newCar.Model} - {newCar.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (var newTruck in OrderedTrucks)
            {
                Console.WriteLine($"{newTruck.Brand}: {newTruck.Model} - {newTruck.Weight}kg");
            }
        }
    }
}
