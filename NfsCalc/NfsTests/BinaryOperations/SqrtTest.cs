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
    public class SqrtTest
    {
        [TestMethod]
        public void TestMethodSqrt()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("Sqrt");
            double result = calc.Calculate(4);
            Assert.AreEqual(2, result, 0.001, "Error");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethodSqrtFail()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("Sqrt");
            double result = calc.Calculate(-4);
        }
    }
}
