using System;
using MyOperations;

class Program
{
    static void Main()
    {
        Operations operations = new Operations();

        // Menu loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Perform Division");
            Console.WriteLine("2. Access Array Element");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1-3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PerformDivision(operations);
                    break;

                case "2":
                    AccessArrayElement(operations);
                    break;

                case "3":
                    Console.WriteLine("Exiting the program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice, please select again.");
                    break;
            }

            // Pause before showing the menu again
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }
    }

    // Perform division method
    static void PerformDivision(Operations operations)
    {
        try
        {
            Console.Write("Enter numerator for division: ");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter denominator for division: ");
            int denominator = Convert.ToInt32(Console.ReadLine());
            int result = operations.Divide(numerator, denominator);
            Console.WriteLine($"Result: {result}");
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine($"Custom Exception Caught: {ex}");
        }
    }

    // Access array element method
    static void AccessArrayElement(Operations operations)
    {
        try
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Console.Write("Enter index to access: ");
            int index = Convert.ToInt32(Console.ReadLine());
            int element = operations.AccessArrayElement(array, index);
            Console.WriteLine($"Array element at index {index}: {element}");
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine($"Custom Exception Caught: {ex}");
        }
    }
}
