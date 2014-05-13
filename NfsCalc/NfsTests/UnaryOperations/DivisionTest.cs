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
    public class DivisionTest
    {
        [TestMethod]
        public void TestMethod2()
        {
            IBinaryCalculator calc= BinaryCalculatorFactory.CreateBinaryCalculator("Division");
            double result = calc.Calculate(3, 2);
            Assert.AreEqual(1.5,result,0.001,"Error");
        }
    }
}
