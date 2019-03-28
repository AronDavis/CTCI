using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Chapter1.Tests
{
    [TestClass]
    public class Q8Tests
    {
        [TestMethod]
        public void TestNull()
        {
            var result = Q8.IsRotation(null, null);
            Assert.IsTrue(result);

            result = Q8.IsRotation("", null);
            Assert.IsFalse(result);

            result = Q8.IsRotation(null, "");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestTrue()
        {
            var s1 = "abc";
            var s2 = "bca";
            var result = Q8.IsRotation(s1, s2);
            Assert.IsTrue(result);

            result = Q8.IsRotation(s2, s1);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestFalse()
        {
            var s1 = "abab";
            var s2 = "ab";
            var result = Q8.IsRotation(s1, s2);
            Assert.IsFalse(result);

            result = Q8.IsRotation(s2, s1);
            Assert.IsFalse(result);
        }
    }
}
