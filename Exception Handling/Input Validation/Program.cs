using System;

class InputValidationApp
{
    static void Main()
    {
        Console.WriteLine("Enter a numeric value:");

        try
        {
            string userInput = Console.ReadLine();
            int numericValue = int.Parse(userInput);
            Console.WriteLine("Input value: " + numericValue);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }

        Console.ReadLine();
    }
}
