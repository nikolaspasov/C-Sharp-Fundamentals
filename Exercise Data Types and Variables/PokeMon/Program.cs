using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int currPower = power;
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            int pokeCount = 0;

            while (currPower >= distance)
            {
                currPower = currPower - distance;
                pokeCount++;
                if(currPower==power*0.500&&exhaustion>0)
                {
                    
                        currPower = currPower / exhaustion;

                }
            }
            Console.WriteLine(currPower);
            Console.WriteLine(pokeCount);
        }
    }
}
