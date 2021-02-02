using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int power = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                power = 0;
                if (input[i] == '>')
                {

                    power = int.Parse(input[i + 1].ToString());

                    sb.Append(input[i]);
                    if (power >= input.Length - i)
                    {
                        for (int j = i + 1; j < input.Length; j++)
                        {
                            if (input[j] == '>')
                            {
                                sb.Append('>');
                            }
                        }
                        Console.WriteLine(sb);
                        return;
                    }
                    for (int j = i + 1; j <= i + power; j++)
                    {

                        if (input[j] == '>')
                        {
                            sb.Append(input[j]);
                            power += int.Parse(input[j + 1].ToString()) + i + power - i - 1;
                            if (power > input.Length - i)
                            {
                                for (int k = j + 1; k < input.Length; k++)
                                {
                                    if (input[k] == '>')
                                    {
                                        sb.Append('>');
                                    }
                                }
                                Console.WriteLine(sb);
                                return;
                            }
                        }
                    }

                    if (power >= 1)
                    { i += power; }
                }
                else if (power == 0)
                {
                    sb.Append(input[i]);
                }

            }


            Console.WriteLine(sb);
        }
    }
}
