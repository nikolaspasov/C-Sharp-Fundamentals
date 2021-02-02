using System;
using System.Linq;
using System.Text;

namespace Final_Exam_Retake_9_August_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputUsername = Console.ReadLine();

            string command = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            while (command != "Sign up")
            {
                if (command.Contains("Case"))
                {
                    if (command.Split()[1] == "upper")
                    {
                        for (int i = 0; i < inputUsername.Length; i++)
                        {
                            sb.Append(inputUsername[i].ToString().ToUpper());

                        }
                    }
                    else
                    {
                        for (int i = 0; i < inputUsername.Length; i++)
                        {
                            sb.Append(inputUsername[i].ToString().ToLower());

                        }
                    }
                    inputUsername = sb.ToString();
                    Console.WriteLine(inputUsername);
                }
                else if (command.Contains("Reverse"))
                {
                    var startIndex = int.Parse(command.Split()[1]);
                    var lastIndex = int.Parse(command.Split()[2]);
                    if (startIndex >= 0 && startIndex < inputUsername.Length
                        && lastIndex >= 0 && lastIndex < inputUsername.Length)
                    {
                        
                        string word = inputUsername.Substring(startIndex, (lastIndex - startIndex) + 1);
                        Console.WriteLine(string.Join("", word.Reverse()));
                        
                    }
                    else
                    {
                        
                    }
                }
                else if (command.Contains("Cut"))
                {
                    var substring = command.Split()[1];
                    sb.Clear();

                    if (inputUsername.Contains(substring))
                    {
                        sb.Append(inputUsername);
                        var index = inputUsername.IndexOf(substring);
                        sb.Remove(index, substring.Length);
                        inputUsername = sb.ToString();
                        Console.WriteLine(inputUsername);
                    }
                    else
                    {
                        Console.WriteLine($"The word {inputUsername} doesn't contain {substring}.");
                    }
                }
                else if (command.Contains("Replace"))
                {
                    char charToReplace = char.Parse(command.Split()[1]);
                    sb.Clear();

                    sb.Append(inputUsername);
                    for (int i = 0; i < inputUsername.Length; i++)
                    {
                        if (sb[i] == charToReplace)
                        {
                            sb[i] = '*';
                        }
                    }
                    inputUsername = sb.ToString();
                    Console.WriteLine(inputUsername);
                }
                else if (command.Contains("Check"))
                {
                    char checkChar = char.Parse(command.Split()[1]);
                    if (inputUsername.Contains(checkChar))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine("Your username must contain "+checkChar+".");
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
