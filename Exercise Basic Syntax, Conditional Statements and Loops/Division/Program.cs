using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
           int answer = 0;
            if(num%2==0)
            {
                answer = 2;
            }
            if (num % 3 == 0)
            {
                answer = 3;
            }
            if (num % 6 == 0)
            {
                answer = 6;
            }
            if (num % 7 == 0)
            {
                answer = 7;
            }
            if (num % 10 == 0)
            {
                answer = 10;
            }
            if(answer == 0)
            {
                Console.WriteLine("Not divisible");
                return;
            }
            Console.WriteLine($"The number is divisible by {answer}");
            
        }
    }
}
