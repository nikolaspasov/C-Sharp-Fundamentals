using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            
            bool special = false;



            for (int i = 1; i <= number; i++)
{
               int curr = i;
                while (curr > 0)
{
                    sum += curr % 10;
                    curr = curr / 10;
                }
                special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}",i, special);
                sum = 0;
                
            }
        }
    }
}
