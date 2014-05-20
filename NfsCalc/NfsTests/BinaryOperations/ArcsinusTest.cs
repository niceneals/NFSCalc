using Microsoft.VisualStudio.TestTools.UnitTesting;
using NfsCalc;
using NfsCalc.BinaryOperation;
using NfsCalc.BinaryCalculator;
namespace NfsTests
{
    [TestClass]
    public class ArcsinusTest
    {
        [TestMethod]
        public void TestMethod77()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("Arcsinus");
            double result = calc.Calculate(0);
            Assert.AreEqual(0, result, 0.001, "Error");
        }
    }
}

