using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("WELCOME TO C# CALCULATOR \r");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Built by Luka Saakashvili \r");

            Console.WriteLine("Please Input First Number...");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Input Second Number...");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your Result: {num1} + {num2} = " + (num1 + num2));
                    break;

                case "s":
                    Console.WriteLine($"Your Result: {num1} - {num2} = " + (num1 - num2));
                    break;

                case "m":
                    Console.WriteLine($"Your Result: {num1} - {num2} = " + (num1 * num2));
                    break;

                case "d":
                    Console.WriteLine($"Your Result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
