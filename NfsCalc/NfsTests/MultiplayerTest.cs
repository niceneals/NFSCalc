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
    public class MultiplayerTest
    {
        [TestMethod]
        public void TestMethod3()
        {
            IBinaryCalculator calc=BinaryCalculatorFactory.CreateBinaryCalculator("Multiplayer");
            double result = calc.Calculate(4, 5);
            Assert.AreEqual(20,result,0.001,"Error");
        }
    }
}
