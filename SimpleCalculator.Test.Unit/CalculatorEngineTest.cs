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
            CalculatorOperations.Calculate("add", number1, number2, out double result);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {
            int number1 = 1;
            int number2 = 2;
            CalculatorOperations.Calculate("+", number1, number2, out double result);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SubtractsTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {
            int number1 = 2;
            int number2 = 1;
            CalculatorOperations.Calculate("subtract", number1, number2, out double result);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SubtractsTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {
            int number1 = 2;
            int number2 = 1;
            CalculatorOperations.Calculate("-", number1, number2, out double result);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MultiplyTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {
            int number1 = 3;
            int number2 = 2;
            CalculatorOperations.Calculate("multiply", number1, number2, out double result);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void MultiplyTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {
            int number1 = 3;
            int number2 = 2;
            CalculatorOperations.Calculate("*", number1, number2, out double result);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void DivideTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {
            int number1 = 4;
            int number2 = 2;
            CalculatorOperations.Calculate("divide", number1, number2, out double result);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {
            int number1 = 4;
            int number2 = 2;
            CalculatorOperations.Calculate("/", number1, number2, out double result);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideByZero()
        {
            int number1 = 4;
            int number2 = 0;
            bool success = CalculatorOperations.Calculate("/", number1, number2, out double result);
            Assert.AreEqual(0, result);
            Assert.IsFalse(success);
        }
    }
}
