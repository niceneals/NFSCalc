using Microsoft.VisualStudio.TestTools.UnitTesting;
using NfsCalc;
using NfsCalc.BinaryOperation;
using NfsCalc.BinaryCalculator;
namespace NfsTests
{
    [TestClass]
    public class CtgTest
    {
        [TestMethod]
        public void TestCtg()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("Ctg");
            double result = calc.Calculate(1);
            Assert.AreEqual(0.64, result, 0.01, "Error");
        }
    }
}