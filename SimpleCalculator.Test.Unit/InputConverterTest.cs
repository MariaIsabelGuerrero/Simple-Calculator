using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber;
            InputConverter.ConvertInputToNumeric(inputNumber, out convertedNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        public void FailsToConvertsInvalidStringInputIntoDouble()
        {
            string inputNumber = "*";
            bool success = InputConverter.ConvertInputToNumeric(inputNumber, out double convertedNumber);
            Assert.AreEqual(0, convertedNumber);
            Assert.IsFalse(success);
        }
    }
}
