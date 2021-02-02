using System;
using System.Text;

namespace Final_Exam_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();
            while(command!="Travel")
            {
                StringBuilder sb = new StringBuilder();
                if (command.Contains("Add Stop"))
                {
                    var index = int.Parse(command.Split(":")[1]);
                    var destination = command.Split(":")[2];
                    if (index >= 0 && index < input.Length)
                    {
                        sb.Append(input);
                        sb.Insert(index, destination);
                        input = sb.ToString();
                    }
                        Console.WriteLine(input);
                    
                    
                }
                else if(command.Contains("Remove Stop"))
                {                
                    var startIndex = int.Parse(command.Split(":")[1]);
                    var endIndex = int.Parse(command.Split(":")[2]);
                    if (startIndex >= 0 && startIndex < input.Length
                        && endIndex >= startIndex && endIndex < input.Length)
                    {
                        
                        sb.Append(input);                      
                        sb.Remove(startIndex, endIndex - startIndex + 1);
                        input = sb.ToString();
                       
                    }
                    Console.WriteLine(input);

                }
                else if(command.Contains("Switch"))
                {
                    var oldString = command.Split(":")[1];
                    var newString = command.Split(":")[2];

                    if (input.Contains(oldString))
                    {
                        sb.Append(input);
                        sb.Replace(oldString, newString);
                        input = sb.ToString();
                    }
                        Console.WriteLine(input);
                    
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {input}");


        }
    }
}
