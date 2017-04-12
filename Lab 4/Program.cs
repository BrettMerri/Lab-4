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
                Console.Clear();
                Console.Write("Please type in a number between 1 and 10: ");
                string input = Console.ReadLine(); //Prompts user for integer input
                int inputNumber = isValidInteger(input);
                if (inputNumber == -1)
                {
                    continue;
                }
                int output = factorial(inputNumber);
                Console.WriteLine("{0}! = {1}", inputNumber, factorial(inputNumber));
                Console.ReadKey();

            }
        }
        public static int isValidInteger(string input)
        {
            int x;
            if (!int.TryParse(input, out x)) //Validating user input to ensure it is an integer
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Input not a number");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Gray;
                return -1;
            }
            if (x < 1 || x > 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Input not between 1 and 10");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Gray;
                return -1;
            }
            return x;
        }
        public static int factorial(int input)
        {
            int x = 1;
            for (int i = 1; i <= input; i++)
            {
                x = x * i;
            }
            return x;
        }
    }
}
