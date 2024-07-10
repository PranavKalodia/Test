using System;

class Program
{
    static void Main(string[] args)
    {
        try 
        {
          
            Console.Write("Enter the first number: ");
            string firstNumberInput = Console.ReadLine();
        
            
            int firstNumber;
            if (!int.TryParse(firstNumberInput, out firstNumber))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            
            Console.Write("Enter the second number: ");
            string secondNumberInput = Console.ReadLine();
        
            
            int secondNumber;
            if (!int.TryParse(secondNumberInput, out secondNumber))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

           
            int sum = firstNumber - secondNumber;

            
            Console.WriteLine("The sum of {0} and {1} is {2}.", firstNumber, secondNumber, sum);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
