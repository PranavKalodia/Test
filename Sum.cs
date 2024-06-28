using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the first number
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();
        
        // Convert the input to an integer
        int number1 = int.Parse(input1);

        // Prompt the user to enter the second number
        Console.Write("Enter the second number: ");
        string input2 = Console.ReadLine();
        
        // Convert the input to an integer
        int number2 = int.Parse(input2);

        // Calculate the sum of the two numbers
        int sum = number1 + number2;

        // Output the result
        Console.WriteLine("The sum of {0} and {1} is {2}.", number1, number2, sum);
    }
}
