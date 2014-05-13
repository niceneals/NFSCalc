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
    public class SinTest
    {
        [TestMethod]
        public void TestMethod9()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("Sin");
            double result = calc.Calculate(2);
            Assert.AreEqual(0.909, result, 0.001, "Error");
        }
    }
}
