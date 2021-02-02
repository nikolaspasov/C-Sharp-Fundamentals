using System;
using System.Collections.Generic;

namespace Vehicle_Catalogue
{
    class Vehicle
    {
        public string Type;
        public string Model;
        public string Color;
        public int HorsePower;

    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Vehicle> vehicleList = new List<Vehicle>();
            while(input!="End")
            {
                Vehicle newVehicle = new Vehicle();

                newVehicle.Type = input.Split()[0];
                newVehicle.Model = input.Split()[1];
                newVehicle.Color = input.Split()[2];
                newVehicle.HorsePower =int.Parse(input.Split()[3]);

                vehicleList.Add(newVehicle);
                input = Console.ReadLine();
            }

            string vehicleFilter = Console.ReadLine();
            while (vehicleFilter!="Close the Catalogue")
            {


                foreach (var newVehicle in vehicleList)
                {
                    if (vehicleFilter == newVehicle.Model)
                    {
                        if (newVehicle.Type == "car")
                        {
                            Console.WriteLine($"Type: Car");
                        }
                        else { Console.WriteLine($"Type: Truck"); }
                        Console.WriteLine($"Model: {newVehicle.Model}");
                        Console.WriteLine($"Color: {newVehicle.Color}");
                        Console.WriteLine($"Horsepower: { newVehicle.HorsePower}");
                       
                    }
                   
                }
                vehicleFilter = Console.ReadLine();
                
            }
            int carHorsePower = 0;
            int truckHorsePower = 0;
            int carCount = 0;
            int truckCount = 0;
            foreach (var newVehicle in vehicleList)
            {
                if(newVehicle.Type=="car")
                {
                    carHorsePower += newVehicle.HorsePower;
                    carCount++;
                }
                else if(newVehicle.Type=="truck")
                {
                    truckHorsePower += newVehicle.HorsePower;
                    truckCount++;
                }
            }
            if(carCount==0)
            {
                carCount = 1;
            }
            if(truckCount==0)
            {
                truckCount = 1;
            }
            Console.WriteLine($"Cars have average horsepower of: {(double)carHorsePower/(double)carCount:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {(double)truckHorsePower/(double)truckCount:f2}.");


        }
    }
}
