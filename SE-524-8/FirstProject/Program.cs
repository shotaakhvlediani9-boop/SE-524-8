// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main()
    {
        // 1. Prompt the user to enter the first number
        Console.Write("Enter the first number:4 ");

        // 2. Read the input from the console and convert it to a double
        // The Convert.ToDouble function handles the conversion from the input string
        double number1 = Convert.ToDouble(Console.ReadLine());

        // 3. Prompt the user to enter the second number
        Console.Write("Enter the second number: ");

        // 4. Read the second input from the console and convert it to a double
        double number2 = Convert.ToDouble(Console.ReadLine());

        // 5. Calculate the sum of the two numbers and store it in a variable named 'sum'
        double sum = number1 + number2;

        // 6. Print the result to the console window
        Console.WriteLine($"The sum of {number1} and {number2} is: {sum}");
    }
}
