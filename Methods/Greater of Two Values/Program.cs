using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();
            GetMax(type, value1, value2);
        }
        static void GetMax(string type, string value1, string value2)
        {
            if(type=="int")
            {
                int integer1 = int.Parse(value1);
                int integer2 = int.Parse(value2);
                Console.WriteLine(Math.Max(integer1,integer2));
            }
            else if(type=="char")
            {
                int char1 = char.Parse(value1);
                int char2 = char.Parse(value2);

                int charValue1 = (int)char1;
                int charValue2 = (int)char2;
                if(charValue1>charValue2)
                {
                    Console.WriteLine(value1);
                }
                else { Console.WriteLine(value2); }
            }
            else if(type =="string")
            {
                if(string.Compare(value1,value2)<0)
                {
                    Console.WriteLine(value2);
                }
                else { Console.WriteLine(value1); }
            }
        }

    }
}
