using Microsoft.VisualStudio.TestTools.UnitTesting;
using NfsCalc;
using NfsCalc.BinaryOperation;
using NfsCalc.BinaryCalculator;
namespace NfsTests
{
    [TestClass]
    public class DivisionOneIntoXTest
    {
        [TestMethod]
        public void TestDivisionOneInto()
        {
            IBinaryOperation calc = MonoFactory.CreateBinaryOperation("DivisionOneIntoX");
            double result = calc.Calculate(2);
            Assert.AreEqual(0.5, result, 0.001, "Error");
        }
    }
}