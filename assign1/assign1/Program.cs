using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Shuffle first and last character of a string");
            Console.WriteLine("2. Calculate the sum of digits of an integer");
            Console.WriteLine("3. Check if the number is a palindrome");
            Console.WriteLine("4. Calculate the square root of a number");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter a string: ");
                    string inputString = Console.ReadLine();
                    string shuffledString = ShuffleString(inputString);
                    Console.WriteLine("Shuffled string: " + shuffledString);
                    break;

                case 2:
                    Console.Write("Enter an integer: ");
                    string sumInput = Console.ReadLine();
                    int sum = CalculateSumOfDigits(sumInput);
                    Console.WriteLine("Sum of digits: " + sum);
                    break;

                case 3:
                    Console.Write("Enter an integer: ");
                    int palindromeNumber = Convert.ToInt32(Console.ReadLine());
                    if (IsPalindrome(palindromeNumber))
                    {
                        Console.WriteLine($"{palindromeNumber} is a Palindrome number.");
                    }
                    else
                    {
                        Console.WriteLine($"{palindromeNumber} is not a Palindrome number.");
                    }
                    break;

                case 4:
                    Console.Write("Enter a number to find the square root: ");
                    double number = Convert.ToDouble(Console.ReadLine());
                    CalculateSquareRoot(number);
                    break;

                case 5:
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    static string ShuffleString(string input)
    {
        if (input.Length > 1)
        {
            return input[input.Length - 1] + input.Substring(1, input.Length - 2) + input[0];
        }
        return input;
    }

    static int CalculateSumOfDigits(string num)
    {
        int sum = 0;
        foreach (char digitChar in num)
        {
            if (char.IsDigit(digitChar))
            {
                sum += int.Parse(digitChar.ToString());
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
                return 0;
            }
        }
        return sum;
    }

    static bool IsPalindrome(int num)
    {
        int original = num;
        int reversed = 0;

        while (num > 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }

        return original == reversed;
    }

    static void CalculateSquareRoot(double num)
    {
        try
        {
            if (num < 0)
            {
                throw new InvalidOperationException("Cannot calculate the square root of a negative number.");
            }

            double result = Math.Sqrt(num);
            Console.WriteLine("Square root: " + result);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
