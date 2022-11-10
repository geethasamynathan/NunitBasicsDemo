using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CalculationLibrary;
namespace Calculator.Tests
{
    [TestFixture]
    class CalculatorTest
    {
        [TestCase]
        public void When_Add2plus3Number_Expect_Result5()
        {
            //arrange
           CalculationLibrary. Calculator calculator = new CalculationLibrary.Calculator();
           //act
            int actualresult = calculator.Addition(2, 3);

            //assert
            Assert.AreEqual(5, actualresult);

        }

        [TestCase]
        public void When_subtract3minus3_Expect_Result0()
        {
            //arrange
            CalculationLibrary.Calculator calculator = new CalculationLibrary.Calculator();
            //act
            int actualresult = calculator.subtraction();

            //assert
            Assert.AreEqual(10, actualresult);

        }
    }
}
