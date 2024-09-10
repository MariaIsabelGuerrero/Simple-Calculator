using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorEngine
{
    public static class CalculatorOperations
    {
        public static bool Calculate(string argOperation, double argFirstNumber, double argSecondNumber, out double result)
        {
            switch (argOperation.ToLower())
            {
                case "+":
                case "add":
                    result = argFirstNumber + argSecondNumber;
                    break;

                case "-":
                case "subtract":
                    result = argFirstNumber - argSecondNumber;
                    break;

                case "/":
                case "divide":
                    if (argSecondNumber != 0)
                        result = argFirstNumber / argSecondNumber;
                    else {
                        result = 0;
                        return false;
                    }
                    break;

                case "*":
                case "multiply":
                    result = argFirstNumber * argSecondNumber;
                    break;

                case "^":
                case "pow":
                    result = Math.Pow(argFirstNumber, argSecondNumber);
                    break;

                default:
                    result = 0;
                    return false;
            }
            return true;
        }
    }
}
