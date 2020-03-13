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
            BasicCalculator calc = new BasicCalculator();
            calc.Add(4, 5);
            Assert.AreEqual(9, calc.Result);
        }
    }
}