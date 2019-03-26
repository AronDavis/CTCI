using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chapter1.Tests
{
    [TestClass]
    public class Q5Tests
    {
        [TestMethod]
        public void TestNull()
        {
            string str = null;
            string result = Q5.Compress(str);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestEmpty()
        {
            string str = "";
            string result = Q5.Compress(str);

            Assert.AreEqual(str, result);
        }

        [TestMethod]
        public void TestCompress()
        {
            string str = "aaaabbbccd";
            string result = Q5.Compress(str);

            Assert.AreEqual("a4b3c2d1", result);
        }

        [TestMethod]
        public void TestNoCompress()
        {
            string str = "aabb";
            string result = Q5.Compress(str);

            Assert.AreEqual(str, result);
        }
    }
}
