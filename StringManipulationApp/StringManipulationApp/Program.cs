// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

namespace StringManipulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DisplayMenu();
        }

        // Menu for string manipulation options
        static void DisplayMenu()
        {
            bool exit = false;
            while (!exit)
            {
                // Display the menu options
                Console.Clear();
                Console.WriteLine("Select an operation for string manipulation:");
                Console.WriteLine("1. Reverse a string");
                Console.WriteLine("2. Convert to uppercase");
                Console.WriteLine("3. Convert to lowercase");
                Console.WriteLine("4. Replace characters in string");
                Console.WriteLine("5. Count occurrences of a character");
                Console.WriteLine("6. Check if string is palindrome");
                Console.WriteLine("7. Exit");

                // Get the user choice
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ReverseString();
                        break;
                    case "2":
                        ToUpperCase();
                        break;
                    case "3":
                        ToLowerCase();
                        break;
                    case "4":
                        ReplaceCharacters();
                        break;
                    case "5":
                        CountCharacterOccurrences();
                        break;
                    case "6":
                        CheckPalindrome();
                        break;
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        // Reverse a string
        static void ReverseString()
        {
            Console.Write("Enter the string to reverse: ");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine($"Reversed String: {reversedString}");
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }

        // Convert to uppercase
        static void ToUpperCase()
        {
            Console.Write("Enter the string to convert to uppercase: ");
            string input = Console.ReadLine();
            string upperString = input.ToUpper();
            Console.WriteLine($"Uppercase String: {upperString}");
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }

        // Convert to lowercase
        static void ToLowerCase()
        {
            Console.Write("Enter the string to convert to lowercase: ");
            string input = Console.ReadLine();
            string lowerString = input.ToLower();
            Console.WriteLine($"Lowercase String: {lowerString}");
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }

        // Replace characters in string
        static void ReplaceCharacters()
        {
            Console.Write("Enter the string: ");
            string input = Console.ReadLine();
            Console.Write("Enter the character to replace: ");
            char oldChar = Console.ReadKey().KeyChar;
            Console.Write("\nEnter the character to replace it with: ");
            char newChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            string replacedString = input.Replace(oldChar, newChar);
            Console.WriteLine($"Modified String: {replacedString}");
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }

        // Count occurrences of a character in string
        static void CountCharacterOccurrences()
        {
            Console.Write("Enter the string: ");
            string input = Console.ReadLine();
            Console.Write("Enter the character to count: ");
            char characterToCount = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int count = CountCharacter(input, characterToCount);
            Console.WriteLine($"Character '{characterToCount}' appears {count} times.");
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }

        // Helper method to count occurrences of a character
        static int CountCharacter(string str, char character)
        {
            int count = 0;
            foreach (var ch in str)
            {
                if (ch == character)
                {
                    count++;
                }
            }
            return count;
        }

        // Check if the string is a palindrome
        static void CheckPalindrome()
        {
            Console.Write("Enter the string to check for palindrome: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is NOT a palindrome.");
            }
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }

        // Helper method to check if the string is a palindrome
        static bool IsPalindrome(string str)
        {
            string cleaned = str.Replace(" ", "").ToLower();  // Remove spaces and make lowercase
            char[] charArray = cleaned.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            return cleaned == reversed;
        }
    }
}
