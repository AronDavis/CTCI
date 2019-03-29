using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Chapter11.Tests
{
    [TestClass]
    public class Q11Tests
    {
        [TestMethod]
        public void TestNull()
        {
            int[] a = null;
            int[] b = null;
            Q1.Merge(a, b, 0, 0);

            Assert.IsNull(a);
            Assert.IsNull(b);
        }

        [TestMethod]
        public void TestMerge()
        {
            int[] a = new int[] { 1, 3, 5, 0, 0 };
            int[] b = new int[] { 2, 4 };
            Q1.Merge(a, b, 3, b.Length);

            Assert.IsTrue(a.Select((v,i) => v == i+1).All(result => result));

            a = new int[] { 2, 4, 0, 0, 0 }; 
            b = new int[] { 1, 3, 5 };
            Q1.Merge(a, b, 2, b.Length);
        }
    }
}
