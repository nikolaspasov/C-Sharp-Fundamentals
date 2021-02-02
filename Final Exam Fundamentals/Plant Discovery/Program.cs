using System;
using System.Collections.Generic;
using System.Linq;

namespace Plant_Discovery
{
    class PlantData
    {
        public int Rarity;
        public double Rating;
        public int RatingCount;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, PlantData> plantDict = new Dictionary<string, PlantData>();

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                var plantToAdd = input.Split("<->")[0];
                var rarity = int.Parse(input.Split("<->")[1]);

                PlantData newPlant = new PlantData();
                newPlant.Rarity = rarity;
                newPlant.Rating = 0.00;
                newPlant.RatingCount = 0;
                plantDict.Add(plantToAdd, newPlant);
            }
            string command = Console.ReadLine();

            while(command!= "Exhibition")
            {
                if(command.Contains("Rate:"))
                {
                    var plantToRate = command.Split()[1];
                    var rating =double.Parse(command.Split()[3]);

                    if(plantDict.ContainsKey(plantToRate))
                    {
                        plantDict[plantToRate].Rating += rating;
                        plantDict[plantToRate].RatingCount++;

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if(command.Contains("Update:"))
                {
                    var plantToUpdate = command.Split()[1];
                    var newRarity = int.Parse(command.Split()[3]);
                    if(plantDict.ContainsKey(plantToUpdate))
                    {
                        plantDict[plantToUpdate].Rarity = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if(command.Contains("Reset:"))
                {
                    var plantToReset = command.Split()[1];
                    if(plantDict.ContainsKey(plantToReset))
                    {
                        plantDict[plantToReset].Rating = 0;
                        plantDict[plantToReset].RatingCount = 0;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
                command = Console.ReadLine();
            }
            foreach (var plant in plantDict)
            {
                if (plant.Value.Rating == 0 | plant.Value.RatingCount == 0)
                {
                    plant.Value.Rating = 0.00;
                }
                else
                {
                    plant.Value.Rating = plant.Value.Rating / plant.Value.RatingCount;
                }
            }
           plantDict= plantDict.OrderByDescending(x => x.Value.Rarity)
                .ThenByDescending(x => x.Value.Rating).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plantDict)
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {plant.Value.Rating:f2}");
            }

            //Plants for the exhibition:
//- { plant_name}; Rarity: { rarity}; Rating: { average_rating formatted to the 2nd digit}
        }
    }
}
