using System;

namespace MidExam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());

           
            int count = 0;
            double bonus = 0;
            double maxBonus = 0;
            int maxLectures = 0;
            while(count<studentCount)
            {
                int attendances = int.Parse(Console.ReadLine());
                count++;
                

                bonus = Math.Round(((double)attendances / lectures) * (5 + initialBonus));

                if(bonus>maxBonus)
                {
                    maxBonus = bonus;
                    maxLectures = attendances;
                }
               
                
            }
            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxLectures} lectures.");
        }
    }
}
