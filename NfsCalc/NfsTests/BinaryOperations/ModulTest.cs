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
    public class ModulTest
    {
        [TestMethod]
        public void TestModul()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("Modul");
            double result = calc.Calculate(-4);
            Assert.AreEqual(4, result, 0.001, "Error");
        }
    }
}
