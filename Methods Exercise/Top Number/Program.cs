using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= num; i++)
            {
              bool  divisible = DivisibleBy8(i);
               bool oddDigit = OddDigit(i);
                if(divisible==true&&oddDigit==true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool DivisibleBy8(int number)
        {
            int currNum = 0;
            int sum = 0;

            while (number > 0)
            {
                currNum = number % 10;
                number = number / 10;
                sum += currNum;
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool OddDigit(int number)
        {
            int currNum = 0;
            int oddCount = 0;
            while (number>0)
            {
                currNum = number % 10;
                number = number / 10;
               
                if(currNum%2!=0)
                {
                    oddCount++;
                    
                }         
            }
            if (oddCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
