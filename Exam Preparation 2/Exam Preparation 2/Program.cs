using System;
using System.Text;

namespace Exam_Preparation_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder changedString = new StringBuilder();
            changedString.Append(input);
            string command = Console.ReadLine();
            while (command != "Reveal")
            {
                if (command.Contains("ChangeAll"))
                {
                    var symbolToChange = command.Split(":|:")[1];
                    var newSymbol = command.Split(":|:")[2];
                    changedString.Replace(symbolToChange, newSymbol);
                    input = changedString.ToString();
                    Console.WriteLine(input);
                }
                if (command.Contains("Reverse"))
                {

                    var substringToReverse = command.Split(":|:")[1];
                    if (input.Contains(substringToReverse))
                    {
                        var index = input.IndexOf(substringToReverse);
                        changedString.Remove(index, substringToReverse.Length);
                        for (int i = substringToReverse.Length - 1; i >= 0; i--)
                        {
                            changedString.Append(substringToReverse[i]);
                        }
                        input = changedString.ToString();
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                if (command.Contains("InsertSpace"))
                {
                    var indexToInsert = int.Parse(command.Split(":|:")[1]);
                    changedString.Insert(indexToInsert, " ");
                    input = changedString.ToString();
                    Console.WriteLine(input);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}
