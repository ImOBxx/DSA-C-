// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        int num1, num2, temp;

        // Input first number with null handling
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();
        if (!int.TryParse(input1, out num1))
        {
            Console.WriteLine("Invalid input for the first number.");
            return;
        }

        // Input second number with null handling
        Console.Write("Enter the second number: ");
        string input2 = Console.ReadLine();
        if (!int.TryParse(input2, out num2))
        {
            Console.WriteLine("Invalid input for the second number.");
            return;
        }

        // Swapping logic
        temp = num1;
        num1 = num2;
        num2 = temp;

        // Output the result
        Console.WriteLine("\nAfter Swapping:");
        Console.WriteLine("First Number : " + num1);
        Console.WriteLine("Second Number : " + num2);

        // Wait for the user to press a key
        Console.Read();
    }
}
