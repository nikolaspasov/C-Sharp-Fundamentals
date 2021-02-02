using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool length = CheckLength(password);
            bool content = CheckContent(password);
            bool digits = CheckDigits(password);
            if(length==true&&content==true&&digits==true)
            {
                Console.WriteLine("Password is valid");
            }
             if(length==false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
             if(content==false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
             if(digits==false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

        }
        static bool CheckLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
                
            }

        }
        static bool CheckContent(string password)
        {
            int value;
            for (int i = 0; i < password.Length; i++)
            {
                value = (int)password[i];
                if (value < 48 || value > 57 &&
                value < 65 || value > 90 && value < 97 || value > 122)
                {
                    return false;
                    
                    
                }
                
                    
                
            }
            return true;


        }
        static bool CheckDigits(string password)
        {
            int value = 0;
            int digitCount = 0;
            for (int i = 0; i < password.Length; i++)
            {
                value = (int)password[i];
                if(value >=48&&value<=57)
                {
                    digitCount++;
                }
            }
            if(digitCount>=2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
