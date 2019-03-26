using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chapter1.Tests
{
    [TestClass]
    public class Q2Tests
    {
        [TestMethod]
        public void TestNull()
        {
            Assert.IsNull(Q2.Reverse(null));
        }

        [TestMethod]
        public void TestEmpty()
        {
            Assert.AreEqual("", Q2.Reverse(""));
        }

        [TestMethod]
        public void TestReverse()
        {
            Assert.AreEqual("abc123", Q2.Reverse("321cba"));
        }
    }
}
