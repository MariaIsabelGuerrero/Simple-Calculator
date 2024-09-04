using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorEngine;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {
            int number1 = 1;
            int number2 = 2;
            double result = CalculatorOperations.Calculate("add", number1, number2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {
            int number1 = 1;
            int number2 = 2;
            double result = CalculatorOperations.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);
        }
    }
}
