using System;
using System.IO.MemoryMappedFiles;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string rightPassword = "";
            int wrongCount = 1;
           string password = Console.ReadLine();
            for (int i = username.Length-1; i >= 0; i--)
            {
                rightPassword += username[i];
            }
            
            
            while (password != rightPassword)
            {
                wrongCount++;
                if (wrongCount > 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");

               

                
                
                password = Console.ReadLine();


            }
            if(password==rightPassword)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            



        }
    }
}
