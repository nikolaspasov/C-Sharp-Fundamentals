using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Speed_Racing
{
    public class Cars
    {
        public string Model;
        public double FuelAmount;
        public double FuelPerKilometer;
        public double TraveledDistance;


        public void DriveDistance(double DistanceToTravel)
        {
            double neededFuel = DistanceToTravel * FuelPerKilometer;
            if (neededFuel <= FuelAmount)
            {
                FuelAmount -= neededFuel;
                TraveledDistance += DistanceToTravel;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Cars> carList = new List<Cars>();
            string carInput = "";
            for (int i = 0; i < numberOfCars; i++)
            {
                carInput = Console.ReadLine();
                Cars newCar = new Cars();
                newCar.Model = carInput.Split()[0];
                newCar.FuelAmount = double.Parse(carInput.Split()[1]);
                newCar.FuelPerKilometer = double.Parse(carInput.Split()[2]);
                newCar.TraveledDistance = 0;
                carList.Add(newCar);
            }
            List<string> commandList = new List<string>();
            string command = Console.ReadLine();
            while (command != "End")
            {
                double distanceToTravel = double.Parse(command.Split()[2]);
                string modelToTravel = command.Split()[1];
                commandList.Add(command);
                command = Console.ReadLine();
            }
            foreach (var newCar in carList)
            {
                foreach (var newCommand in commandList)
                {
                    if(newCar.Model==newCommand.Split()[1])
                    {
                        newCar.DriveDistance(double.Parse(newCommand.Split()[2]));
                    }
                }
            }
            foreach (var newCar in carList)
            {
                Console.WriteLine($"{newCar.Model} {newCar.FuelAmount:f2} {newCar.TraveledDistance}");
            }
        }
    }
}
