using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalSabre = (sabrePrice * Math.Ceiling(students*1.10));
            double totalRobe = robePrice * students;
            
            double totalBelt = beltPrice * students;
            if (students>=6)
            {
                totalBelt = beltPrice * (students - students / 6);
            }
            double totalPrice = totalBelt + totalSabre + totalRobe;

            if(money<totalPrice)
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice-money:f2}lv more.");
            }

            else if(money>=totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
        }
    }
}
