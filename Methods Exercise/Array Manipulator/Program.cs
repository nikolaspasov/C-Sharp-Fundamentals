using System;
using System.Linq;
using System.Security.Principal;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] exchangedArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();


            int maxIndex = 0;
            int minIndex = 0;

            while (command != "end")
            {
                if (command.Contains("exchange"))
                {

                    ExchangeArray(exchangedArray, command);



                }

                else if (command.Contains("max"))
                {
                    GetMaxIndex(exchangedArray, command);

                
                }
                else if (command.Contains("min"))
                {


                    GetMinIndex(exchangedArray, command);

                }
                else if (command.Contains("first"))
                {
                    GetFirstEvenOdd(exchangedArray, command);





                }
                else if (command.Contains("last"))
                {

                    GetLastEvenOdd(exchangedArray, command);


                }

                command = Console.ReadLine();
            }

            Console.Write("[");
            for (int i = 0; i < exchangedArray.Length; i++)
            {



                if (i == exchangedArray.Length - 1)
                {
                    Console.WriteLine(exchangedArray[i] + "]");
                }
                else
                {
                    Console.Write(exchangedArray[i] + ", ");
                }

            }

        }
        static void ExchangeArray(int[] exchangeArray, string command)
        {
            int exchangeIndex = int.Parse(command.Split()[1]);

            int[] newArrayOne = new int[exchangeIndex + 1];
            int count = 0;
            if (exchangeIndex > exchangeArray.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            else
            {

                for (int i = 0; i < newArrayOne.Length; i++)
                {

                    newArrayOne[i] = exchangeArray[i];
                }
                int[] newArrayTwo = new int[exchangeArray.Length - exchangeIndex - 1];
                for (int i = newArrayOne.Length; i <= exchangeArray.Length - 1; i++)
                {


                    newArrayTwo[count] = exchangeArray[i];
                    count++;
                }
                for (int i = 0; i < newArrayTwo.Length; i++)
                {
                    exchangeArray[i] = newArrayTwo[i];
                }
                for (int i = 0; i < newArrayOne.Length; i++)
                {
                    exchangeArray[newArrayTwo.Length + i] = newArrayOne[i];
                }
            }

        }
        static void GetMaxIndex(int[] exchangedArray, string command)
        {
            int maxIndex = 0;
            int maxEvenNum = int.MinValue;
            int maxOddNum = int.MinValue;
            int counter = 0;

            if (command == "max even")
            {

                for (int i = 0; i < exchangedArray.Length; i++)
                {
                    if (exchangedArray[i] % 2 == 0 && exchangedArray[i] >= maxEvenNum)
                    {
                        maxEvenNum = exchangedArray[i];
                        maxIndex = i;
                        counter++;
                    }
                }

            }
            else if (command == "max odd")
            {
                for (int i = 0; i < exchangedArray.Length; i++)
                {
                    if (exchangedArray[i] % 2 != 0 && exchangedArray[i] >= maxOddNum)
                    {
                        maxOddNum = exchangedArray[i];
                        maxIndex = i;
                        counter++;
                    }
                }


            }
            if (counter == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }

        }
        static void GetMinIndex(int[] exchangedArray, string command)
        {
            int minIndex = 0;
            int minEvenNum = int.MaxValue;
            int minOddNum = int.MaxValue;
            int counter = 0;


            if (command == "min even")
            {

                minEvenNum = exchangedArray.Max();
                for (int i = exchangedArray.Length - 1; i >= 0; i--)
                {
                    if (exchangedArray[i] <= minEvenNum && exchangedArray[i] % 2 == 0)
                    {
                        minIndex = i;
                        minEvenNum = exchangedArray[i];
                        counter++;
                    }
                }
            }
            else if (command == "min odd")
            {
                minOddNum = exchangedArray.Max();
                for (int i = exchangedArray.Length - 1; i >= 0; i--)
                {
                    if (exchangedArray[i] <= minOddNum && exchangedArray[i] % 2 != 0)
                    {
                        minIndex = i;
                        minOddNum = exchangedArray[i];
                        counter++;
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minIndex);
            }

        }
        static void GetFirstEvenOdd(int[] exchangedArray, string command)
        {
            int setCount = 0;
            int count = 0;

            setCount = int.Parse(command.Split()[1]);
            int[] firstEvenOdd = new int[setCount];
            if (command.Contains("even"))
            {

                for (int i = 0; i < exchangedArray.Length; i++)
                {
                    if (setCount > exchangedArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                        return;
                    }
                    if (exchangedArray[i] % 2 == 0)
                    {

                        firstEvenOdd[count] = exchangedArray[i];
                        count++;
                    }
                    if (count >= setCount)
                    {
                        break;
                    }
                }
            }
            if (command.Contains("odd"))
            {

                for (int i = 0; i < exchangedArray.Length; i++)
                {
                    if (setCount > exchangedArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                        return;
                    }
                    if (exchangedArray[i] % 2 != 0)
                    {

                        firstEvenOdd[count] = exchangedArray[i];
                        count++;
                    }
                    if (count >= setCount)
                    {
                        break;
                    }
                }
            }

            {
                Console.Write("[");

                for (int i = 0; i < firstEvenOdd.Length ; i++)
                {
                    if (firstEvenOdd[i] == 0)
                    {
                        Console.Write("]");
                        Console.WriteLine("");
                        break;
                    }

                    if (firstEvenOdd[i] != 0)
                    {

                        if (i == firstEvenOdd.Length-1)
                        {
                            Console.WriteLine(firstEvenOdd[i] + "]");
                            break;
                        }
                        else
                        {

                            Console.Write(firstEvenOdd[i]);
                        }
                        if (firstEvenOdd[firstEvenOdd.Length-1] != 0)
                        {
                            Console.Write(", ");

                        }

                    }

                }
            }

        }
        static void GetLastEvenOdd(int[] exchangedArray, string command)
        {
            int setCount = 0;
            int count = 0;
            setCount = int.Parse(command.Split()[1]);
            int[] lastEvenOdd = new int[setCount];

            if (command.Contains("even"))
            {


                for (int i = exchangedArray.Length - 1; i >= 0; i--)
                {
                    if (setCount > exchangedArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                        return;
                    }
                    if (setCount <= count)
                    { break; }
                    if (exchangedArray[i] % 2 == 0)
                    {

                        lastEvenOdd[count] = exchangedArray[i];
                        count++;
                    }

                }
            }
            else if (command.Contains("odd"))
            {
                setCount = int.Parse(command.Split()[1]);

                for (int i = exchangedArray.Length - 1; i >= 0; i--)
                {
                    if (setCount > exchangedArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                        return;
                    }
                    if (setCount <= count)
                    { break; }
                    if (exchangedArray[i] % 2 != 0)
                    {

                        lastEvenOdd[count] = exchangedArray[i];
                        count++;
                    }

                }

            }
            int nonZeroCounter = 0;
            Console.Write("[");
            for (int i = lastEvenOdd.Length-1; i >=0 ; i--)
            {
                if(lastEvenOdd[i]==0)
                {
                    continue;
                }
                else if (i ==0)
                {
                    Console.WriteLine(lastEvenOdd[i] + "]");
                    nonZeroCounter++;
                }
                else
                {
                    Console.Write(lastEvenOdd[i]);
                    nonZeroCounter++;
                }
                if (i >0)
                {
                    if (lastEvenOdd[lastEvenOdd.Length -1] != 0)
                    {
                        Console.Write(", ");

                    }
                }
            }
            if (nonZeroCounter == 0)
            {
                Console.Write("]");
                Console.WriteLine("");
                return;
            }

        }
    }
}
