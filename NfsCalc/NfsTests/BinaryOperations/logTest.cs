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
    public class logTest
    {
        [TestMethod]
        public void TestMethodlog()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("log");
            double result = calc.Calculate(1);
            Assert.AreEqual(0, result, 0.001, "Error");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethodlogFail()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("log");
            double result = calc.Calculate(-4);
        }
    }
}
