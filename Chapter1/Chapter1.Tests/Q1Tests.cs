using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chapter1.Tests
{
    [TestClass]
    public class Q1Tests
    {
        [TestMethod]
        public void TestNull()
        {
            Assert.IsTrue(Q1.HasUniqueChars(null));
        }

        [TestMethod]
        public void TestEmpty()
        {
            Assert.IsTrue(Q1.HasUniqueChars(""));
        }

        [TestMethod]
        public void TestUnique()
        {
            Assert.IsTrue(Q1.HasUniqueChars("abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ"));
        }

        [TestMethod]
        public void TestNotUnique()
        {
            Assert.IsFalse(Q1.HasUniqueChars("aa"));
        }
    }
}
