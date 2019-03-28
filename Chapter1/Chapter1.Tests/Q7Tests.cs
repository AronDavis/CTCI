using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Chapter1.Tests
{
    [TestClass]
    public class Q7Tests
    {
        [TestMethod]
        public void TestNull()
        {
            int[][] arr = null;
            Q7.SetZeros(arr);

            Assert.IsNull(arr);

            arr = new int[1][];
            Q7.SetZeros(arr);

            Assert.AreEqual(1, arr.Length);
            Assert.IsNull(arr[0]);
        }

        [TestMethod]
        public void TestBadLength()
        {
            int[][] arr = new int[][]
            {
                new int[] {0, 2 },
                new int[] { 3 }
            };

            Q7.SetZeros(arr);

            Assert.AreEqual(2, arr.Length);
            Assert.AreEqual(2, arr[0].Length);
            Assert.AreEqual(1, arr[1].Length);

            Assert.AreEqual(0, arr[0][0]);
            Assert.AreEqual(2, arr[0][1]);
            Assert.AreEqual(3, arr[1][0]);
        }

        [TestMethod]
        public void TestTall()
        {
            int[][] arr = new int[][]
            {
                new int[] { 0, 2 },
                new int[] { 1, 2 },
                new int[] { 1, 2 },
                new int[] { 1, 2 }
            };

            Q7.SetZeros(arr);

            Assert.AreEqual(4, arr.Length);
            Assert.IsTrue(arr.All(a => a.Length == 2));

            Assert.IsTrue(arr.All(a => a[0] == 0));
            Assert.AreEqual(0, arr[0][1]);
            Assert.AreEqual(2, arr[1][1]);
            Assert.AreEqual(2, arr[2][1]);
            Assert.AreEqual(2, arr[3][1]);
        }

        [TestMethod]
        public void TestWide()
        {
            int[][] arr = new int[][]
            {
                new int[] { 0, 2, 3, 4 },
                new int[] { 1, 2, 3, 4 }
            };

            Q7.SetZeros(arr);

            Assert.AreEqual(2, arr.Length);
            Assert.IsTrue(arr.All(a => a.Length == 4));

            Assert.IsTrue(arr[0].All(a => a == 0));
            Assert.AreEqual(0, arr[1][0]);
            Assert.AreEqual(2, arr[1][1]);
            Assert.AreEqual(3, arr[1][2]);
            Assert.AreEqual(4, arr[1][3]);
        }
    }
}
