using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chapter1.Tests
{
    [TestClass]
    public class Q3Tests
    {
        [TestMethod]
        public void TestBothNull()
        {
            Assert.IsTrue(Q3.IsPermutation(null, null));
        }

        [TestMethod]
        public void TestS1Null()
        {
            Assert.IsFalse(Q3.IsPermutation("", null));
        }

        [TestMethod]
        public void TestS2Null()
        {
            Assert.IsFalse(Q3.IsPermutation(null, ""));
        }

        [TestMethod]
        public void TestEmpty()
        {
            Assert.IsTrue(Q3.IsPermutation("",""));
        }

        [TestMethod]
        public void TestPermutation()
        {
            Assert.IsTrue(Q3.IsPermutation("abc", "abc"));
            Assert.IsTrue(Q3.IsPermutation("abc", "cba"));
            Assert.IsTrue(Q3.IsPermutation("aBc", "acB"));
        }

        [TestMethod]
        public void TestNotPermutation()
        {
            Assert.IsFalse(Q3.IsPermutation("Abc", "cba"));
        }
    }
}
