using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password__Checker
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Password Checker with C#.

            This program  measures the strength of any given password based on the following criteria. A strong password:

                is at least 8 characters long
                has lowercase letters
                has uppercase letters
                has numerical digits
                has symbols, like #, ?, !
                The program will ask the user to input a password, and using conditional logic and control flow, it will rate the password.
              
            Author: Ricardo Carvalheira

             */

            // Let the user know that the program is starting:

            Console.WriteLine("Initializing the PasswordChecker!");


            string title = "Password Checker";

            Console.WriteLine("\r\n\t" + title);
            

            int minLength = 8;
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "#?!,.*-+/|";

            Console.Write("\r\nEnter a password: ");
            string userPassword = Console.ReadLine();
            int score = 0;

            if (userPassword.Length >= minLength) score++;
            if (Tools.Contains(userPassword, upperCase)) score++;
            if (Tools.Contains(userPassword, lowerCase)) score++;
            if (Tools.Contains(userPassword, digits)) score++;
            if (Tools.Contains(userPassword, specialChars)) score++;

            switch (score.ToString())
            {
                case "5":
                    Console.WriteLine("The password is extremely strong");
                    break;

                case "4":
                    Console.WriteLine("The password is extremely strong");
                    break;

                case "3":
                    Console.WriteLine("The password is strong");
                    break;

                case "2":
                    Console.WriteLine("The password is medium");
                    break;

                case "1":
                    Console.WriteLine("The password is weak");
                    break;

                default:
                    Console.WriteLine("The password doesn’t meet any of the standards");
                    break;
            }

            Console.WriteLine("\r\n     Press Enter to close tab...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
