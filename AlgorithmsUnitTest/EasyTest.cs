using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsUnitTest
{
    [TestClass]
    public class EasyTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int[] ar = new int[] { 1, 2 };
            int expected = 3;
            int actual;

            //act
            actual = Easy.SimpleArraySum(ar);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
