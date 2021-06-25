using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Add(2, 2) == 4);
            //Assert.Fail();
        }

        [TestMethod()]
        public void SubstractTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Substract(4, 3) == 1);
            //Assert.Fail();
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Multiply(2, 3) == 6);
            //Assert.Fail();
        }
    }
}