using System;

namespace DelegateCalculator
{
    class Program
    {
        // Declare a delegate type for mathematical operations
        public delegate double Operation(double x, double y);

        static void Main(string[] args)
        {
            // Call the main menu to interact with the user
            DisplayMenu();
        }

        // Menu for the calculator
        static void DisplayMenu()
        {
            bool exit = false;
            while (!exit)
            {
                // Show available operations
                Console.Clear();
                Console.WriteLine("Select a mathematical operation:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                // User input for operation choice
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PerformOperation(Add);
                        break;
                    case "2":
                        PerformOperation(Subtract);
                        break;
                    case "3":
                        PerformOperation(Multiply);
                        break;
                    case "4":
                        PerformOperation(Divide);
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        // Method to perform the operation based on user input
        static void PerformOperation(Operation operation)
        {
            try
            {
                Console.Write("Enter the first number: ");
                double num1 = GetValidatedInput();

                Console.Write("Enter the second number: ");
                double num2 = GetValidatedInput();

                double result = operation(num1, num2);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }

        // Validation method to ensure valid numerical input
        static double GetValidatedInput()
        {
            double number;
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out number))
                {
                    return number;
                }
                else
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }
            }
        }

        // Basic mathematical operations

        // Addition
        static double Add(double x, double y)
        {
            return x + y;
        }

        // Subtraction
        static double Subtract(double x, double y)
        {
            return x - y;
        }

        // Multiplication
        static double Multiply(double x, double y)
        {
            return x * y;
        }

        // Division with error handling for division by zero
        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return x / y;
        }
    }
}
