using System;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeSpeed = int.Parse(Console.ReadLine());
            int secondEmployeeSpeed = int.Parse(Console.ReadLine());
            int thirdEmployeeSpeed = int.Parse(Console.ReadLine());

            int totalStudents = int.Parse(Console.ReadLine());
            int hourCount = 0; 

            while(totalStudents>0)
            {
                hourCount++;
                if (hourCount %4==0)
                {

                    continue;
                }
                int speed = firstEmployeeSpeed + secondEmployeeSpeed + thirdEmployeeSpeed;
                totalStudents -= speed;
                
               
                if(totalStudents<=0)
                {
                    break;
                }
                
            }
            Console.WriteLine($"Time needed: {hourCount}h.");


        }
    }
}
