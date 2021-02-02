using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string output = GetMatrix(n);
            Console.WriteLine(output);
        }
        static string GetMatrix(int number)
        {
            string output = "";
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    output += number + " ";
                }
                output+="\n";
            }
            return output;

        }
    }
}