using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int currNum = 0;
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                currNum = i;
                while(currNum>0)
                {
                    sum += currNum % 10;
                    currNum = currNum / 10;
                }
                if(sum== 5 || sum==7 || sum==11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                sum = 0;
            }
        }
    }
}
