using Microsoft.VisualStudio.TestTools.UnitTesting;
using NfsCalc;
using NfsCalc.BinaryOperation;
using NfsCalc.BinaryCalculator;
namespace NfsTests
{
    [TestClass]
    public class ArccosinusTest
    {
        [TestMethod]
        public void TestMethod10()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("Arccosinus");
            double result = calc.Calculate(0);
            Assert.AreEqual(0, result, 0.001, "Error");
        }
    }
}

