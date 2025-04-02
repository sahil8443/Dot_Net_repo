// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

namespace DigitSumCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Digit Sum and Manipulation Calculator!");

            // User input for the number
            Console.Write("Enter a positive integer: ");
            string input = Console.ReadLine();

            // Validate the input
            if (!int.TryParse(input, out int number) || number <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a valid positive integer.");
                return; // Exit if invalid input
            }

            // Call the method to process the number
            ProcessNumber(number);
        }

        // Process number: calculate digit sum, manipulate digits, etc.
        static void ProcessNumber(int number)
        {
            // Convert number to an array of digits
            int[] digits = GetDigits(number);

            // Calculate the sum of digits
            int digitSum = CalculateDigitSum(digits);
            Console.WriteLine($"Sum of digits: {digitSum}");

            // Perform mathematical operations on individual digits
            PerformDigitOperations(digits);
        }

        // Get digits from an integer (breaks it down into an array)
        static int[] GetDigits(int number)
        {
            string numStr = number.ToString();
            int[] digits = new int[numStr.Length];

            for (int i = 0; i < numStr.Length; i++)
            {
                digits[i] = int.Parse(numStr[i].ToString());
            }

            return digits;
        }

        // Calculate the sum of the digits
        static int CalculateDigitSum(int[] digits)
        {
            int sum = 0;
            foreach (int digit in digits)
            {
                sum += digit;
            }
            return sum;
        }

        // Perform operations on individual digits
        static void PerformDigitOperations(int[] digits)
        {
            Console.WriteLine("\nMathematical Operations on Individual Digits:");
            Console.WriteLine("1. Squaring each digit");
            Console.WriteLine("2. Product of digits");

            // Square each digit and display result
            Console.Write("Squared digits: ");
            foreach (int digit in digits)
            {
                Console.Write(digit * digit + " ");
            }
            Console.WriteLine();

            // Find product of digits
            int product = 1;
            foreach (int digit in digits)
            {
                product *= digit;
            }
            Console.WriteLine($"Product of digits: {product}");
        }
    }
}
