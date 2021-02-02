using System;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int health = 100;
            int totalBitcoins = 0;
            int bitcoins = 0;
            string input = Console.ReadLine();
            string[] array = input.Split("|");

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i].Contains("potion"))
                {
                    int potion = int.Parse(array[i].Split()[1]);
                    int healing = 0;
                    if(health+potion>100)
                    {
                        healing = 100 - health;
                    }
                    else
                    {
                        healing = potion;
                    }
                    health += healing;
                    Console.WriteLine($"You healed for {healing} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if(array[i].Contains("chest"))
                {
                    bitcoins = int.Parse(array[i].Split()[1]);
                    Console.WriteLine($"You found {bitcoins} bitcoins.");
                    totalBitcoins += bitcoins;
                }
                else
                {
                    int monsterAttack = int.Parse(array[i].Split()[1]);
                    if(health-monsterAttack>0)
                    {
                        Console.WriteLine($"You slayed {array[i].Split()[0]}.");
                        health -= monsterAttack;
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {array[i].Split()[0]}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {totalBitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
