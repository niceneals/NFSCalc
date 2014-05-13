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
    public class log2_XTest
    {
        [TestMethod]
        public void Testlog2_X()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("log2_X");
            double result = calc.Calculate(4);
            Assert.AreEqual(2, result, 0.001, "Error");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Testlog2_XFail()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("log2_X");
            double result = calc.Calculate(-4);
        }
    }
}