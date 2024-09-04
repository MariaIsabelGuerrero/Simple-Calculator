using System;

namespace SimpleCalculator
{
    public static class InputConverter
    {
        public static bool ConvertInputToNumeric(string argTextInput, out double result)
        {
            return double.TryParse(argTextInput, out result);
        }
    }
}
