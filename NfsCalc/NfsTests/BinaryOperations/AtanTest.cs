using Microsoft.VisualStudio.TestTools.UnitTesting;
using NfsCalc;
using NfsCalc.BinaryOperation;
using NfsCalc.BinaryCalculator;
namespace NfsTests
{
    [TestClass]
    public class AtanTest
    {
        [TestMethod]
        public void TestMethod12()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("Atan");
            double result = calc.Calculate(0);
            Assert.AreEqual(0, result, 0.001, "Error");
        }
    }
}