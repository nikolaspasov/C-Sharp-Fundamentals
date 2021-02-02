using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string input = Console.ReadLine();
            string stringOne = input.Split()[0];
            string stringTwo = input.Split()[1];
            int firstCode = 0;
            int secondCode = 0;
           
           if(stringOne.Length>stringTwo.Length)
            {
                for (int i = 0; i < stringTwo.Length; i++)
                {
                    firstCode = (int)stringOne[i];
                    secondCode = (int)stringTwo[i];
                    sum += firstCode * secondCode;
                }
                for (int i = stringTwo.Length; i < stringOne.Length; i++)
                {
                    
                    sum+= (int)stringOne[i];
                }
            }
            else if(stringTwo.Length>stringOne.Length)
            {
                for (int i = 0; i < stringOne.Length; i++)
                {
                    firstCode = (int)stringOne[i];
                    secondCode = (int)stringTwo[i];
                    sum += firstCode * secondCode;
                }
                for (int i = stringOne.Length; i < stringTwo.Length; i++)
                {

                    sum += (int)stringTwo[i];
                }
            }
           else
            {
                for (int i = 0; i < stringOne.Length; i++)
                {
                    firstCode = (int)stringOne[i];
                    secondCode = (int)stringTwo[i];
                    sum += firstCode * secondCode;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
