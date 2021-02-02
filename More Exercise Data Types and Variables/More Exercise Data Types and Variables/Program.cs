using System;

namespace More_Exercise_Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            
            //while(input!="END")
            //{
            //  string  dataType= input.GetType().Name;
            //    Console.WriteLine(dataType);
            //    input = Console.ReadLine();
            //}
            while(input!="END")
            {
                bool intTryParse = int.TryParse(input, out int intResult);
                bool doubleTryParse = double.TryParse(input, out double doubleResult);
                bool charTryParse = char.TryParse(input, out char charResult);
                bool boolTryParse = bool.TryParse(input, out bool boolResult);

                if(intTryParse==true)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if(doubleTryParse==true)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if(charTryParse==true)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if(boolTryParse==true)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else 
                { 
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
            

        }
    }
}
