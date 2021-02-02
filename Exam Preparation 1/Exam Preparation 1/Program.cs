using System;
using System.Text;

namespace Exam_Preparation_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string input = Console.ReadLine();
            StringBuilder newPassword = new StringBuilder();
            newPassword.Append(password);
            StringBuilder oddChars = new StringBuilder();
            while (input != "Done")
            {
                if (input.Contains("TakeOdd"))
                {
                    for (int i = 1; i < newPassword.Length; i += 2)
                    {
                        oddChars.Append(newPassword[i]);
                    }
                    newPassword = oddChars;
                    Console.WriteLine(newPassword);
                }
                else if (input.Contains("Cut"))
                {

                    newPassword.Remove(int.Parse(input.Split()[1]), int.Parse(input.Split()[2]));
                    Console.WriteLine(newPassword);
                }
                else if (input.Contains("Substitute"))
                {

                    if (!newPassword.ToString().Contains(input.Split()[1]))
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                    else
                    {
                        newPassword.Replace(input.Split()[1], input.Split()[2]);
                        Console.WriteLine(newPassword);
                    }
                }
                input = Console.ReadLine();
            }
            if (newPassword.ToString() == string.Empty)
            {
                Console.WriteLine($"Your password is: {password}");
            }
            else
            {
                Console.WriteLine($"Your password is: {newPassword}");
            }
        }
    }
}
