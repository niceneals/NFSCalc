using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NfsCalc;
using NfsCalc.BinaryOperation;
using NfsCalc.BinaryCalculator;
namespace NFSTest
{
    [TestClass]
    public class Powm2Test
    {
        [TestMethod]
        public void TestMethod8()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("Powm2");
            double result = calc.Calculate(2);
            Assert.AreEqual(4, result, 0.001, "Error");
        }
    }
}