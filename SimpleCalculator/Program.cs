using System;
using CalculatorEngine;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());

                string operation = Console.ReadLine();

                double result = CalculatorOperations.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}
