using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NfsCalc;
using NfsCalc.BinaryCalculator;

namespace NfsTests
{
    [TestClass]
    public class PowTest
    {
        [TestMethod]
        public void TestMethod4()
        {
            IBinaryCalculator calc = BinaryCalculatorFactory.CreateBinaryCalculator("Pow(m,n)");
            double result = calc.Calculate(2, 4);
            Assert.AreEqual(16,result,0.001,"Error");
        }
    }
}
