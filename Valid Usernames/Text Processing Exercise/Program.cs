using System;

namespace Text_Processing_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] array = input.Split(", ");
            string username = "";
            bool isTrue = true;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length >= 3 && array[i].Length <= 16)
                {
                    username = array[i];
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        if (char.IsLetterOrDigit(username[j]) || username[j] == '-' || username[j] == '_')
                        {
                            
                        }
                        else
                        {
                            isTrue = false;
                        }
                    }
                    if(isTrue==true)
                    {
                        Console.WriteLine(username);
                    }
                    isTrue = true;
                    
                }

            }
        }
    }
}
