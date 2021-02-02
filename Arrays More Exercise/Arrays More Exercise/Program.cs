using System;

namespace Arrays_More_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = "";
            char[] arr = new char[n];
            int vowelSum = 0;
            int consonantSum = 0;
            int[] totalSum = new int[n];
            int value = 0;


            for (int i = 0; i < n; i++)
            {
                name = Console.ReadLine();
                arr = name.ToCharArray();

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == 'a' || arr[j] == 'e' || arr[j] == 'i' || arr[j] == 'o' || arr[j] == 'u' ||
                        arr[j] == 'A' || arr[j] == 'E' || arr[j] == 'I' || arr[j] == 'O' || arr[j] == 'U')
                    {

                        value = (int)arr[j];
                        vowelSum += value * arr.Length;

                    }
                    else
                    {
                        value = (int)arr[j];
                        consonantSum += value / arr.Length;
                    }
                }
                totalSum[i] = vowelSum + consonantSum;

                vowelSum = 0;
                consonantSum = 0;

            }

            Array.Sort(totalSum);

            for (int i = 0; i < totalSum.Length; i++)
            {
                Console.WriteLine(totalSum[i]);
            }

        }
    }
}
