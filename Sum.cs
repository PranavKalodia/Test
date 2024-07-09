using System;

class Program
{
    static void Main(string[] args)
    {
        try 
        {
            // Prompt the user to enter the first number
            Console.Write("Enter the first number: ");
            string firstNumberInput = Console.ReadLine();
        
            // Convert the input to an integer
            int firstNumber;
            if (!int.TryParse(firstNumberInput, out firstNumber))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            // Prompt the user to enter the second number
            Console.Write("Enter the second number: ");
            string secondNumberInput = Console.ReadLine();
        
            // Convert the input to an integer
            int secondNumber;
            if (!int.TryParse(secondNumberInput, out secondNumber))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            // Calculate the sum of the two numbers
            int sum = firstNumber + secondNumber;

            // Output the result
            Console.WriteLine("The sum of {0} and {1} is {2}.", firstNumber, secondNumber, sum);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}