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
        public void AddTest()
        {

            BasicCalculator calculator = new BasicCalculator();
            calculator.Add(5, 4);
            Assert.AreEqual(9, calculator.Result);
        }
    }
}