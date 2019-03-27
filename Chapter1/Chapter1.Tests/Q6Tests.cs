using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Chapter1.Tests
{
    [TestClass]
    public class Q6Tests
    {
        [TestMethod]
        public void TestNull()
        {
            int[][] arr = null;
            Q6.RotateMatrix90(arr, 0);

            Assert.IsNull(arr);

            arr = new int[1][];
            Q6.RotateMatrix90(arr, 1);

            Assert.AreEqual(1, arr.Length);
            Assert.IsNull(arr[0]);
        }

        [TestMethod]
        public void TestBadLength()
        {
            int[][] arr = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 }
            };

            Q6.RotateMatrix90(arr, 1);

            Assert.AreEqual(2, arr.Length);
            Assert.IsTrue(arr.All(a => a.Length == 2));

            Assert.AreEqual(1, arr[0][0]);
            Assert.AreEqual(2, arr[0][1]);
            Assert.AreEqual(3, arr[1][0]);
            Assert.AreEqual(4, arr[1][1]);
        }

        [TestMethod]
        public void TestSingle()
        {
            int[][] arr = new int[][]
            {
                new int[] { 1 }
            };

            Q6.RotateMatrix90(arr, 1);

            Assert.AreEqual(1, arr.Length);
            Assert.AreEqual(1, arr[0].Length);
            Assert.AreEqual(1, arr[0][0]);
        }

        [TestMethod]
        public void TestEven()
        {
            int[][] arr = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 }
            };

            Q6.RotateMatrix90(arr, 2);

            Assert.AreEqual(2, arr.Length);
            Assert.IsTrue(arr.All(a => a.Length == 2));

            Assert.AreEqual(1, arr[0][1]);
            Assert.AreEqual(2, arr[1][1]);
            Assert.AreEqual(3, arr[0][0]);
            Assert.AreEqual(4, arr[1][0]);
        }

        [TestMethod]
        public void TestOdd()
        {
            int[][] arr = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            Q6.RotateMatrix90(arr, 3);

            Assert.AreEqual(3, arr.Length);
            Assert.IsTrue(arr.All(a => a.Length == 3));

            Assert.AreEqual(1, arr[0][2]);
            Assert.AreEqual(2, arr[1][2]);
            Assert.AreEqual(3, arr[2][2]);
            Assert.AreEqual(4, arr[0][1]);
            Assert.AreEqual(5, arr[1][1]);
            Assert.AreEqual(6, arr[2][1]);
            Assert.AreEqual(7, arr[0][0]);
            Assert.AreEqual(8, arr[1][0]);
            Assert.AreEqual(9, arr[2][0]);
        }
    }
}
