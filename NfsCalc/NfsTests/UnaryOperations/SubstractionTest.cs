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
    public class SubstractionTest
    {
        [TestMethod]
        public void TestMethod5()
        {
            IBinaryCalculator calc=BinaryCalculatorFactory.CreateBinaryCalculator("Substraction");
            double result = calc.Calculate(4, 2);
            Assert.AreEqual(2,result,0.001,"Error");
        }
    }
}
