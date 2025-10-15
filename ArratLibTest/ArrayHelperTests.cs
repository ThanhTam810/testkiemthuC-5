using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayLib;
using System;

namespace ArrayLibTest
{
    [TestClass]
    public class ArrayHelperTests
    {
        [TestMethod]
        public void FindMax_ReturnsCorrectValue()
        {
            int[] arr = { 1, 5, 3, 9, 2 };
            Assert.AreEqual(9, ArrayHelper.FindMax(arr));
        }

        [TestMethod]
        public void FindMin_ReturnsCorrectValue()
        {
            int[] arr = { 1, 5, 3, 9, 2 };
            Assert.AreEqual(1, ArrayHelper.FindMin(arr));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindMax_EmptyArray_ThrowsException()
        {
            ArrayHelper.FindMax(new int[] { });
        }
    }
}