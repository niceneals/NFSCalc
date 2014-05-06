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
    public class Powm3Test
    {
        [TestMethod]
        public void TestMethod7()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("Powm3");
            double result = calc.Calculate(2);
            Assert.AreEqual(8, result, 0.001, "Error");
        }


    }
}
