using System;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] array = input.Split();
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int rndPosition = rnd.Next(array.Length);
                string curr = array[i];
                array[i] = array[rndPosition];
                array[rndPosition] = curr;

            }
            Console.WriteLine(string.Join(Environment.NewLine, array));
        }
    }
}
