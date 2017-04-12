using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.Write("Please type in a number between 1 and 65: ");

                string input = Console.ReadLine(); //Prompts user for integer input

                int inputNumber = isValidInteger(input); //Validates if input is an integer and its between 1 and 65
                if (inputNumber == 0) //Restarts application if an error has occurred
                {
                    Console.WriteLine();
                    continue;
                }

                ulong output = factorial(Convert.ToUInt64(inputNumber)); //Calculates factorial with a for loop

                Console.WriteLine("{0}! = {1}\n", inputNumber, output); //Output: 3! = 6

                if (!continueApp()) //If user does not want to continue app, close app. Otherwise - restart app.
                {
                    return;
                }
            }
        }
        public static int isValidInteger(string input)
        {
            int x;
            if (!int.TryParse(input, out x)) //Validates if user input is an integer
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Input not a number"); //Prompts error if input is not a number
                Console.ForegroundColor = ConsoleColor.Gray;
                return 0;
            }
            if (x < 1 || x > 65) //Validates if user input is between 1 and 10
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Input not between 1 and 65"); //Prompts error if input is not between 1 and 10
                Console.ForegroundColor = ConsoleColor.Gray;
                return 0;
            }
            return x;
        }
        public static ulong factorial(ulong input)
        {
            ulong x = 1;

            for (ulong i = 1; i <= input; i++) //Calculates factorial with a for loop
            {
                x = x * i;
            }
            return x;
        }
        public static bool continueApp()
        {
            while (true)
            {
                Console.Write("Continue? (y/n): "); //Prompts user if he wants to continue

                string continueString = Console.ReadLine().ToLower();

                if (continueString == "y")
                {
                    Console.WriteLine();
                    return true;
                }
                else if (continueString == "n")
                {
                    return false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Input not y or n."); //Prompts error if input is not Y or N
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                }
            }
        }
    }
}
