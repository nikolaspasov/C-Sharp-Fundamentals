using System;

namespace Exams_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int batchNum = int.Parse(Console.ReadLine());
            int flourGrams = 0;
            int sugarGrams = 0;
            int cocoaGrams = 0;
            int cookiesPerBake = 0;
            int flourCups = 0;
            int sugarSpoons = 0;
            int cocoaSpoons = 0;
            int boxes = 0;
            int smallest = 0;
            int totalBoxes = 0;


            for (int i = 0; i < batchNum; i++)
            {
                flourGrams = int.Parse(Console.ReadLine());
                sugarGrams = int.Parse(Console.ReadLine());
                cocoaGrams = int.Parse(Console.ReadLine());

                flourCups = (int)Math.Floor(flourGrams / 140.0);
                sugarSpoons = (int)Math.Floor(sugarGrams / 20.0);
                cocoaSpoons = (int)Math.Floor(cocoaGrams / 10.0);
                if (flourCups < sugarSpoons && flourCups < cocoaSpoons)
                {
                    smallest = flourCups;
                }
                else if (sugarSpoons < flourCups && sugarSpoons < cocoaSpoons)
                {
                    smallest = sugarSpoons;
                }
                else if(cocoaSpoons<flourCups&&cocoaSpoons<sugarSpoons)
                {
                    smallest = cocoaSpoons;
                }
                else
                {
                    smallest = flourCups;
                }
                cookiesPerBake = (int)Math.Floor(((170 * smallest) / 25.0));
                boxes = (int)Math.Floor(cookiesPerBake / 5.0);
                if (boxes == 0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                }
                else
                {
                    Console.WriteLine($"Boxes of cookies: {boxes}");
                }
                totalBoxes += boxes;


            }
            Console.WriteLine($"Total boxes: {totalBoxes}");

    }
}
}
