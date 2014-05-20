using Microsoft.VisualStudio.TestTools.UnitTesting;
using NfsCalc;
using NfsCalc.BinaryOperation;
using NfsCalc.BinaryCalculator;
namespace NfsTests
{
    [TestClass]
    public class DegreesToRadiansTest
    {
        [TestMethod]
        public void DegreesToRadians()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("DegreesToRadians");
            double result = calc.Calculate(100);
            Assert.AreEqual(1.745, result, 0.001, "Error");
        }
    }
}