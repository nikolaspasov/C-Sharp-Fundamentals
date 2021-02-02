using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Need_for_Speed_III
{
    class CarClass
    {
        public int Mileage;
        public int Fuel;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, CarClass> carsDict = new Dictionary<string, CarClass>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string carInput = Console.ReadLine();
                string name = carInput.Split("|")[0];
                int mileage = int.Parse(carInput.Split("|")[1]);
                int fuel = int.Parse(carInput.Split("|")[2]);
                CarClass newCar = new CarClass() { Mileage = mileage, Fuel = fuel };
                carsDict.Add(name,newCar);
            }
            string command = Console.ReadLine();

            while (command != "Stop")
            {
                if (command.Contains("Drive"))
                {
                    var carToDrive = command.Split(" : ")[1];
                    var kmToDrive = int.Parse(command.Split(" : ")[2]);
                    var neededFuel = int.Parse(command.Split(" : ")[3]);

                    if (carsDict[carToDrive].Fuel >= neededFuel)
                    {
                        Console.WriteLine($"{carToDrive} driven for {kmToDrive} kilometers. {neededFuel} liters of fuel consumed.");
                        carsDict[carToDrive].Mileage += kmToDrive;
                        carsDict[carToDrive].Fuel -= neededFuel;
                        if (carsDict[carToDrive].Mileage > 100000)
                        {
                            Console.WriteLine($"Time to sell the {carToDrive}!");
                            carsDict.Remove(carToDrive);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                }
                else if (command.Contains("Refuel"))
                {
                    var carToFuel = command.Split(" : ")[1];
                    var fuelToRefill = int.Parse(command.Split(" : ")[2]);
                    if (carsDict[carToFuel].Fuel + fuelToRefill >= 75)
                    {
                        Console.WriteLine($"{carToFuel} refueled with {75 - carsDict[carToFuel].Fuel} liters");
                        carsDict[carToFuel].Fuel = 75;
                    }
                    else
                    {
                        carsDict[carToFuel].Fuel += fuelToRefill;
                        Console.WriteLine($"{carToFuel} refueled with {fuelToRefill} liters");
                    }
                }
                else if(command.Contains("Revert"))
                {
                    var carToRevert = command.Split(" : ")[1];
                    var kmToRevert = int.Parse(command.Split(" : ")[2]);
                    if(carsDict[carToRevert].Mileage>kmToRevert)
                    {
                        carsDict[carToRevert].Mileage -= kmToRevert;
                        if(carsDict[carToRevert].Mileage<=10000)
                        {
                            carsDict[carToRevert].Mileage = 10000;
                        }
                        else
                        {
                            Console.WriteLine($"{carToRevert} mileage decreased by {kmToRevert} kilometers");
                        }
                    }
                }

                command = Console.ReadLine();
            }
            //  their mileage in decscending order, then by their name in ascending order
            carsDict = carsDict.OrderByDescending(x => x.Value.Mileage)
                  .ThenBy(x => x.Key).ToDictionary(x => x.Key,x=>x.Value);

            //"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt."

            foreach (var car in carsDict)
            {
                Console.WriteLine
                    ($"{car.Key} -> Mileage: {car.Value.Mileage} kms," +
                    $" Fuel in the tank: {car.Value.Fuel} lt.");
            }
        }
    }
}
