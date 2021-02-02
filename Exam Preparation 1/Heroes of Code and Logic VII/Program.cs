using System;
using System.Collections.Generic;
using System.Linq;

namespace Heroes_of_Code_and_Logic_VII
{
    class HealthAndMana
    {
        public int Health;
        public int ManaPoints;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int heroesCount = int.Parse(Console.ReadLine());
            string heroInput = "";
            Dictionary<string, HealthAndMana> heroDictionary = new Dictionary<string, HealthAndMana>();

            for (int i = 0; i < heroesCount; i++)
            {
                heroInput = Console.ReadLine();
                var name = heroInput.Split()[0];
                var health = int.Parse(heroInput.Split()[1]);
                var manaPoints = int.Parse(heroInput.Split()[2]);

                if (health <= 100 && manaPoints <= 200)
                {
                    HealthAndMana newStats = new HealthAndMana();
                    newStats.Health = health;
                    newStats.ManaPoints = manaPoints;
                    heroDictionary.Add(name, newStats);
                }
            }
            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command.Contains("CastSpell"))
                {
                    var heroToCast = command.Split(" - ")[1];
                    var neededMana = int.Parse(command.Split(" - ")[2]);
                    var spellName = command.Split(" - ")[3];
                    if (heroDictionary[heroToCast].ManaPoints >= neededMana)
                    {
                        heroDictionary[heroToCast].ManaPoints -= neededMana;
                        Console.WriteLine
                            ($"{heroToCast} has successfully cast {spellName}" +
                            $" and now has {heroDictionary[heroToCast].ManaPoints} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroToCast} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command.Contains("TakeDamage"))
                {
                    var heroToTakeDamage = command.Split(" - ")[1];
                    var damageToTake = int.Parse(command.Split(" - ")[2]);
                    var attacker = command.Split(" - ")[3];

                    if (heroDictionary[heroToTakeDamage].Health > damageToTake)
                    {
                        heroDictionary[heroToTakeDamage].Health -= damageToTake;
                        Console.WriteLine
                            ($"{heroToTakeDamage} was hit for {damageToTake}" +
                            $" HP by {attacker} and now has {heroDictionary[heroToTakeDamage].Health} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroToTakeDamage} has been killed by {attacker}!");
                        heroDictionary.Remove(heroToTakeDamage);
                    }

                }
                else if (command.Contains("Recharge"))
                {
                    var heroToRecharge = command.Split(" - ")[1];
                    var manaForRecharge = int.Parse(command.Split(" - ")[2]);

                    if (heroDictionary[heroToRecharge].ManaPoints + manaForRecharge >= 200)
                    {
                        Console.WriteLine($"{heroToRecharge}" +
                            $" recharged for {200 - heroDictionary[heroToRecharge].ManaPoints} MP!");
                        heroDictionary[heroToRecharge].ManaPoints = 200;
                    }
                    else
                    {
                        Console.WriteLine($"{heroToRecharge} recharged for {manaForRecharge} MP!");
                        heroDictionary[heroToRecharge].ManaPoints += manaForRecharge;
                    }
                }
                else if (command.Contains("Heal"))
                {
                    var heroToHeal = command.Split(" - ")[1];
                    var healthAmount = int.Parse(command.Split(" - ")[2]);

                    if (heroDictionary[heroToHeal].Health + healthAmount >= 100)
                    {

                        Console.WriteLine($"{heroToHeal} healed for {100 - heroDictionary[heroToHeal].Health} HP!");
                        heroDictionary[heroToHeal].Health = 100;
                    }
                    else
                    {
                        Console.WriteLine($"{heroToHeal} healed for {healthAmount} HP!");
                        heroDictionary[heroToHeal].Health += healthAmount;
                    }
                }
                command = Console.ReadLine();
            }
            heroDictionary = heroDictionary.OrderByDescending(x => x.Value.Health)
                .ThenBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var hero in heroDictionary)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine("  HP: "+hero.Value.Health);
                Console.WriteLine("  MP: "+hero.Value.ManaPoints);
            }
        }
    }
}
