using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NfsCalc;
using NfsCalc.BinaryOperation;
using NfsCalc.BinaryCalculator;
namespace NfsTests
{
    [TestClass]
    public class FactorialTest
    {
        [TestMethod]
        public void TestMethodFactorial()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("Factorial");
            double result = calc.Calculate(5);
            Assert.AreEqual(120, result, 0.001, "Error");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethodFactorialFail()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("Factorial");
            double result = calc.Calculate(-5);
        }
    }
}
