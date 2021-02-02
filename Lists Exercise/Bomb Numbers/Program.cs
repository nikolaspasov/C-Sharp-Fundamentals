using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            int bombNumber = int.Parse(input.Split()[0]);
            int bombPower = int.Parse(input.Split()[1]);
            while (numbers.Contains(bombNumber))
            {
                for (int index = 0; index < numbers.Count; index++)
                {
                    if (numbers[index] == bombNumber)
                    {
                        int bombPowerCount = bombPower * 2 + 1;

                        if (index - bombPower < 0)
                        {
                            numbers.RemoveRange(0, bombPowerCount);
                        }
                        if (index - bombPower + bombPowerCount > numbers.Count-1)
                        {
                            numbers.RemoveRange(index - bombPower, numbers.Count - (index - bombPower));
                        }
                        else
                        {
                            numbers.RemoveRange(index - bombPower, bombPowerCount);
                        }
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}











