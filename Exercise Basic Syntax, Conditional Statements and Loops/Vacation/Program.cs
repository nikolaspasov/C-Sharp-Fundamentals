using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            switch (day)
            {
                case "Friday":
                    if (groupType == "Students")
                    {
                        price =8.45 ;
                    }

                    else if (groupType == "Business")
                    {
                        price =10.90 ;
                    }

                    else if (groupType == "Regular")
                    {
                        price =15 ;
                    }
                    break;
                case "Saturday":
                    if (groupType == "Students")
                    {
                        price = 9.80;
                    }

                    else if (groupType == "Business")
                    {
                        price =15.60 ;
                    }

                    else if (groupType == "Regular")
                    {
                        price =20 ;
                    }
                    break;
                case "Sunday":
                    if (groupType == "Students")
                    {
                        price =10.46 ;
                    }

                    else if (groupType == "Business")
                    {
                        price = 16;
                    }

                    else if (groupType == "Regular")
                    {
                        price =22.50 ;
                    }
                    break;

            }
            double finalPrice = price * people;
            
            if(people>=30 && groupType=="Students")
            {
                finalPrice = finalPrice * 0.85;
            }
            else if(people>=100 && groupType=="Business")
            {
                finalPrice = finalPrice - 10 * price;
            }
            else if(people>=10 && people<=20 && groupType=="Regular")
            {
                finalPrice = finalPrice * 0.95;
            }
            Console.WriteLine($"Total price: {finalPrice:f2}");
        }
    }
}
