using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Division Calculator");
        Console.WriteLine();

        Console.Write("Enter the first whole number: ");
        string firstInput = Console.ReadLine() ?? "";

        Console.Write("Enter the second whole number: ");
        string secondInput = Console.ReadLine() ?? "";

        try
        {
            int firstNumber = Convert.ToInt32(firstInput);
            int secondNumber = Convert.ToInt32(secondInput);

            int answer = CalculateDivision(firstNumber, secondNumber);

            Console.WriteLine("Division result: " + answer);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter whole numbers.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide a number by zero.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number entered is too large or too small.");
        }
    }

    static int CalculateDivision(int number1, int number2)
    {
        return number1 / number2;
    }
}
