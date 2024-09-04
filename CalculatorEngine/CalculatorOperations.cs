using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorEngine
{
    public static class CalculatorOperations
    {
        public static double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            if (argOperation == "+" || argOperation.ToLower() == "add")
            {
                result = argFirstNumber + argSecondNumber;
            }
            else if (argOperation == "-" || argOperation.ToLower() == "substract")
            {
                result = argFirstNumber - argSecondNumber;
            }

            switch (argOperation.ToLower())
            {
                case "+":
                case "add":
                    result = argFirstNumber + argSecondNumber;
                    break;

                case "-":
                case "substract":
                    result = argFirstNumber - argSecondNumber;
                    break;


            }

            return result;
        }
    }
}
