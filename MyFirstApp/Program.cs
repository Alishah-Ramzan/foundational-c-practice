using System;

namespace Calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            int number1;
            int number2;
            int input;

            Console.WriteLine("Calculator application running...");

            // Get the operation from the user
            Console.WriteLine("Press 1 to add");
            Console.WriteLine("Press 2 to subtract");
            Console.WriteLine("Press 3 to multiply");
            Console.WriteLine("Press 4 to divide");
            input = Convert.ToInt32(Console.ReadLine());

            // Get the numbers from the user
            Console.WriteLine("Enter the first number:");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            number2 = Convert.ToInt32(Console.ReadLine());

            // Perform the selected operation
            switch (input)
            {
                case 1:
                    Console.WriteLine($" {number1 + number2}");
                    break;
                case 2:
                    Console.WriteLine($" {number1 - number2}");
                    break;
                case 3:
                    Console.WriteLine($"{number1 * number2}");
                    break;
                case 4:
                    if (number2 != 0)
                    {
                        Console.WriteLine($" {(double)number1 / number2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input. Please select a valid operation.");
                    break;
                    
            }
        }
    }
}
