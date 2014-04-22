using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NfsCalc;
using NfsCalc.BinaryCalculator;

namespace NfsTests
{
    [TestClass]
    public class AdderTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IBinaryCalculator calc = BinaryCalculatorFactory.CreateBinaryCalculator("Adder");
            double result = calc.Calculate(2, 3);
            Assert.AreEqual(5,result,0.001,"Error");
        }
    }
}
