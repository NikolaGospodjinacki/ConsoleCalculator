using System;
using CalculatorProgram;

namespace CaculatorProgram
{
    class Program 
    {
        static void Main(string[] args)
        {
            bool IsOver = false;
            while (!IsOver)
            {
                string firstInput = "";
                string secondInput = "";
                string @operator = "";
                double result = 0;

                Console.WriteLine("This is a basic command line calculator");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Enter first number:");
                firstInput = Console.ReadLine();

                //Converts input to double, checks if the input is correct
                double firstClean = 0;
                while (!double.TryParse(firstInput, out firstClean))
                {
                    Console.WriteLine("Input for the first number is not valid, try again:\n");
                    firstInput = Console.ReadLine();
                }

                Console.WriteLine("Enter second number");
                secondInput = Console.ReadLine();

                double secondClean = 0;
                while (!double.TryParse(secondInput, out secondClean))
                {
                    Console.WriteLine("Input for the second number is not valid, try again:\n");
                    secondInput = Console.ReadLine();
                }

                Console.WriteLine("Available operations:");
                Console.WriteLine("\ta - Addition");
                Console.WriteLine("\td - Deduction");
                Console.WriteLine("\tm - Multiplication");
                Console.WriteLine("\te - Division");
                Console.WriteLine("Your choice?\n");
               
                @operator = Console.ReadLine();
                try
                {
                    result = CalculatorLibrary.CalculateValue(firstClean, secondClean, @operator);
                    if (double.IsNaN(result) || double.IsInfinity(result))
                    {
                        Console.WriteLine("Calculation is not valid");
                    }
                    else
                    {
                        Console.WriteLine("Result for {0} and {1} is: {2:0.000}", firstClean, secondClean, result);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong, please try again. Details:" + e);
                }

                Console.WriteLine("Do you want to do another calculation?");
                Console.WriteLine("Press n to exit, or anything else to continue.");

                if (Console.ReadLine() == "n")
                {
                    IsOver = true;
                    return;
                }
            }

        }
    }
}
