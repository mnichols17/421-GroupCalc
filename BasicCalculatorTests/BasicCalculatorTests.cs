using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class BasicCalculatorTests
    {
        [TestMethod()]
        public void AddIntTest()
        {
            BasicCalculator calc = new BasicCalculator();
            calc.Add(4, 5);
            Assert.AreEqual(9, calc.Result);
        }

        [TestMethod()]

        public void AddDecimalTest()
        {
            BasicCalculator calc = new BasicCalculator();
            calc.Add(5.5M, 4.5M);
            Assert.AreEqual(10M, calc.Result);
        }

        [TestMethod()]

        public void AddIntArrayTest()
        {
            int[] testArr = { 1, 2, 3 };
            BasicCalculator calc = new BasicCalculator();
            calc.Add(testArr);
            Assert.AreEqual(6, calc.Result);
        }

        [TestMethod()]

        public void AddDecimalArrayTest()
        {
            decimal[] testArr = { 1.5M, 2.5M, 3.5M };
            BasicCalculator calc = new BasicCalculator();
            calc.Add(testArr);
            Assert.AreEqual(7.5M, calc.Result);
        }

        [TestMethod()]

        public void SubtractIntTest()
        {
            
            BasicCalculator calc = new BasicCalculator();
            calc.Subtract(10,5);
            Assert.AreEqual(5, calc.Result);
        }

        [TestMethod()]

        public void SubtractDecimalTest()
        {

            BasicCalculator calc = new BasicCalculator();
            calc.Subtract(10.5M, 5.5M);
            Assert.AreEqual(5, calc.Result);
        }

        [TestMethod()]

        public void SubtractIntArrayTest()
        {
            int[] test = { 5, 1, 2 };
            BasicCalculator calc = new BasicCalculator();
            calc.Subtract(test);
            Assert.AreEqual(2, calc.Result);
        }

        [TestMethod()]

        public void SubtractDecimalArrayTest()
        {
            decimal[] test = {10M, 2.5M, 1M };
            BasicCalculator calc = new BasicCalculator();
            calc.Subtract(test);
            Assert.AreEqual(6.5M, calc.Result);
        }
    }
}