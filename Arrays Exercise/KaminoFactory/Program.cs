using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            

            string bestSequence = "";
            int maxCount = 0;
            int sequenceSum = 0;
            int bestSum = 0;
            int sampleNumber = 1;
            int bestSampleNumber = 1;
            int startingPoint = 0;
            int bestStartingPoint = 0;

            while (input != "Clone them!")
            {
                int onesCount = 0;
                int count = 0;
                
                string[] arr = input.Split(new string[] {"!"}, StringSplitOptions.RemoveEmptyEntries);
                int[] numbers = new int[arr.Length];
                numbers = arr.Select(int.Parse)
                    .ToArray();

                
               
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == 1)
                    {
                        count++;
                        if (count > onesCount)
                        {
                            onesCount = count;
                            startingPoint = i;
                        }

                       
                    }
                    else { count = 0; }
                }

                for (int k = 0; k < numbers.Length; k++)
                {

                    sequenceSum += numbers[k];

                }
                if (onesCount > maxCount)
                {
                    maxCount = onesCount;
                    bestSum = sequenceSum;
                    bestStartingPoint = startingPoint;
                    bestSequence = "";
                    bestSampleNumber = sampleNumber;
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        bestSequence += numbers[j] + " ";
                    }
                    if (sequenceSum > bestSum)
                    {

                        bestStartingPoint = startingPoint;
                        bestSum = sequenceSum;
                        bestSampleNumber = sampleNumber;
                        bestSequence = "";
                        for (int j = 0; j < numbers.Length; j++)
                        {
                            bestSequence += numbers[j] + " ";
                        }
                    }
                }
                else if (onesCount == maxCount)
                {

                    if (startingPoint < bestStartingPoint)
                    {
                        bestSum = sequenceSum;
                        bestStartingPoint = startingPoint;
                        bestSampleNumber = sampleNumber;
                        bestSequence = "";
                        for (int j = 0; j < numbers.Length; j++)
                        {
                            bestSequence += numbers[j] + " ";
                        }
                    }
                    else if (startingPoint <= bestStartingPoint && sequenceSum > bestSum)
                    {

                        bestStartingPoint = startingPoint;
                        bestSampleNumber = sampleNumber;
                        bestSequence = "";


                        bestSum = sequenceSum;
                        bestSampleNumber = sampleNumber;
                        bestSequence = "";
                        for (int j = 0; j < numbers.Length; j++)
                        {
                            bestSequence += numbers[j] + " ";
                        }

                    }
                }

                sequenceSum = 0;
                input = Console.ReadLine();

                if (maxCount == 0)
                {
                    bestSum = sequenceSum;
                    bestStartingPoint = startingPoint;
                    bestSequence = "";
                    bestSampleNumber = sampleNumber;
                    for (int j = 0; j < n; j++)
                    {
                        bestSequence += numbers[j] + " ";
                    }
                }
                else
                {
                    sampleNumber++;
                }


            }
            Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {bestSum}.");
            Console.WriteLine(bestSequence);
        }

    }
}
