using System;
using System.Collections.Generic;

namespace Raw_Data
{
    public class Car
    {
        public string Model;
        public Engine Engine;
        public Cargo Cargo;


        public Car(string aModel, Engine aEngine, Cargo aCargo)
        {
            Model = aModel;
            Engine = aEngine;
            Cargo = aCargo;
        }

    }
    public class Engine
    {
        public int EngineSpeed;
        public int EnginePower;
        public Engine(int aEngineSpeed, int aEnginePower)
        {
            EngineSpeed = aEngineSpeed;
            EnginePower = aEnginePower;
        }
    }
    public class Cargo
    {
        public int CargoWeight;
        public string CargoType;
        public Cargo(int aCargoWeight, string aCargoType)
        {
            CargoWeight = aCargoWeight;
            CargoType = aCargoType;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            string input = string.Empty;
            List<Car> carList = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                input = Console.ReadLine();
                string model = input.Split()[0];

                int engineSpeed = int.Parse(input.Split()[1]);
                int enginePower = int.Parse(input.Split()[2]);
                Engine newEngine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(input.Split()[3]);
                string cargoType = input.Split()[4];
                Cargo newCargo = new Cargo(cargoWeight, cargoType);

                Car newCar = new Car(model, newEngine, newCargo);

                carList.Add(newCar);

            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (var newCar in carList)
                {
                    if (newCar.Cargo.CargoType == command && newCar.Cargo.CargoWeight < 1000)
                    {
                        Console.WriteLine(newCar.Model);
                    }                  
                }
            }
            else if(command=="flamable")
            {
                foreach (var newCar in carList)
                {
                    if(newCar.Cargo.CargoType==command&&newCar.Engine.EnginePower>250)
                    {
                        Console.WriteLine(newCar.Model);
                    }
                }
            }

        }
    }
}
