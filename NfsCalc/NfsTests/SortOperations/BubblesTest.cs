using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NfsCalc.Sort;
using NUnit.Framework;

namespace NfsTests.SortOperations
{
    [TestFixture]
    public class BubblesTest
    {
        [Test]
        public void BubbleSortTest()
        {
            int[] array = {9, 8, 7, 6, 5, 4, 3, 2, 1, 0};
            int[] result = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            ISortOperation calculator = SortFactory.CreateBinaryCalculator("BubbleSort");
            int[] resultSort = calculator.Sort(array);
            Assert.AreEqual(result, resultSort);
        }
    }
}
