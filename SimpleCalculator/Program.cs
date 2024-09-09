using System;
using System.Text;
using CalculatorEngine;


namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                double firstNumber = GetValidNumber("Enter the first number: ");
                double secondNumber = GetValidNumber("Enter the second number: ");
                string operation = GetValidOperation();
                bool success = CalculatorOperations.Calculate(operation, firstNumber, secondNumber, out double result);
                if (success)
                    Console.WriteLine($"The result of {firstNumber} {operation} {secondNumber} = {result:.00}");
                else
                    Console.WriteLine($"The opperation {firstNumber} {operation} {secondNumber} doesn't work");
            }
            catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
        static double GetValidNumber(string prompt)
        {
            double number = 0;
            bool success;
            do {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                success = InputConverter.ConvertInputToNumeric(input, out number);

                if (!success)
                    Console.WriteLine("Invalid input. Please enter a valid number.");

            } while (!success);
            return number;
        }
        static string GetValidOperation()
        {
            while (true)
            {
                Console.WriteLine("Enter the operation: ");
                string operation = Console.ReadLine().Trim().ToLower();
                if (IsValidOperation(operation))
                {
                    return operation;
                }
                Console.WriteLine("Invalid operation. Valid operations are:");
                Console.WriteLine("+ or add for addtion");
                Console.WriteLine("- or subtract for subtraction");
                Console.WriteLine("* or multiply for multiplcation");
                Console.WriteLine("/ or divide for division");

            }
        }
        static bool IsValidOperation(string operation)
        {
            return operation == "+" || operation == "add" ||
                operation == "-" || operation == "subtract" ||
                operation == "*" || operation == "multiply" ||
                operation == "/" || operation == "divide";
        }
        
            
    
        }
    }

