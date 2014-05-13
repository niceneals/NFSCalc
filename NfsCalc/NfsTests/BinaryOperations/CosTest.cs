using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NfsCalc;
using NfsCalc.BinaryOperation;
using NfsCalc.BinaryCalculator;
namespace NfsTests
{
    [TestClass]
    public class CosTest
    {
        [TestMethod]
        public void TestMethod10()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("Cos");
            double result = calc.Calculate(2);
            Assert.AreEqual(-0.416, result, 0.001, "Error");
        }
    }
}
