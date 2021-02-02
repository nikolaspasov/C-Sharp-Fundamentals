using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string output = "";
            for (int i = 97; i <= 97 + n-1; i++)
            {
                char firstChar = (char)i;
               

                for (int j = 97; j <= 97 + n-1; j++)
                {
                    char secondChar = (char)j;
                    

                    for (int k = 97; k <= 97 + n-1; k++)
                    {
                        char thirdChar = (char)k;
                        output = $"{firstChar}{secondChar}{thirdChar}";

                        Console.WriteLine(output);

                        
                    }
                }

                

            }

        }
    }
}
