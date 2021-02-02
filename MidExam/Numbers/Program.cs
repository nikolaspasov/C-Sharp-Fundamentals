using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;
            
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            double averageNum = (double)sum / numbers.Count;

            List<int> biggerNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > averageNum)
                {
                    

                    biggerNumbers.Add(numbers[i]);
                }
            }

            List<int> topNumbers = new List<int>(5);
            int count = 0;
            for (int i = 0; i <= biggerNumbers.Count; i++)
            {
                count++;
                if (biggerNumbers.Count > 0)
                {
                    int maxNumber = biggerNumbers.Max();
                    topNumbers.Add(maxNumber);
                    biggerNumbers.Remove(biggerNumbers.Max());
                }
                i = -1;
                if (count == 5)
                {
                    break;
                }
            }
            if(topNumbers.Count==0)
            {
                Console.WriteLine("No");
            }
            topNumbers.Sort();
            topNumbers.Reverse();
            Console.WriteLine(string.Join(" ", topNumbers));
            
        }
    }
}
