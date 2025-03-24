using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1-100): ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine(FizzBuzzChecker.GetFizzBuzz(number));
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}

public class FizzBuzzChecker
{
    public static string GetFizzBuzz(int number)
    {
        if (number < 1 || number > 100)
            return "Error: Number out of range";

        if (number % 3 == 0 && number % 5 == 0)
            return "Fizz Buzz";
        if (number % 3 == 0)
            return "Fizz";
        if (number % 5 == 0)
            return "Buzz";

        return number.ToString();
    }
}
