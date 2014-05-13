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
    public class PowXETest
    {
        [TestMethod]
        public void TestMethod6()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("powXE");
            double result = calc.Calculate(2);
            Assert.AreEqual(6.49801, result, 0.001, "Error");
        }
    }
}
