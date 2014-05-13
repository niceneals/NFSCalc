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
    public class tgTest
    {
        [TestMethod]
        public void Testtg()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("tg");
            double result = calc.Calculate(1);
            Assert.AreEqual(1.557, result, 0.001, "Error");
        }
    }
}
