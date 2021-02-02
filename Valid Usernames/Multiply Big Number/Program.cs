using System;
using System.Numerics;
using System.Text;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("0");
                return;
            }

            while (bigNumber[0] == '0')
            {
                bigNumber = bigNumber.Trim('0');
            }
            StringBuilder sb = new StringBuilder();
            int remaining = 0;
            int result = 0;
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                result = int.Parse(bigNumber[i].ToString()) * number + remaining;
                remaining = 0;
                if (int.Parse(bigNumber[i].ToString()) * number > 9)
                {
                    remaining = result / 10;
                    result = result % 10;
                }
                sb.Append(result);
            }
            if (remaining != 0)
            {
                sb.Append(remaining);
            }
            StringBuilder finalResult = new StringBuilder();

            for (int i = sb.Length-1; i >=0; i--)
            {
                finalResult.Append(sb[i]);
            }
            Console.WriteLine(finalResult);
        }
    }
}

