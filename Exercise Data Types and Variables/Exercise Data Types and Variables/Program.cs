using System;

namespace Exercise_Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            int operationOne = first + second;
            int operationTwo = operationOne / third;
            int operationThree = operationTwo * fourth;
            Console.WriteLine(operationThree);

        }
    }
}
