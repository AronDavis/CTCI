using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chapter1.Tests
{
    [TestClass]
    public class Q4Tests
    {
        [TestMethod]
        public void TestNull()
        {
            char[] str = null;
            Q4.ReplaceSpacesInPlace(str, 0);

            Assert.IsNull(str);
        }

        [TestMethod]
        public void TestBadInput()
        {
            string str = "1";
            char[] charArray = str.ToCharArray();
            Q4.ReplaceSpacesInPlace(charArray, 2);

            Assert.AreEqual(str, new string(charArray));
        }

        [TestMethod]
        public void TestEmpty()
        {
            string str = "";
            _testSpacesReplaced(str);
        }

        [TestMethod]
        public void TestNoSpaces()
        {
            string str = "abc123";
            _testSpacesReplaced(str);
        }

        [TestMethod]
        public void TestSpacesReplaced()
        {
            string str = " a b c ";
            _testSpacesReplaced(str);

            str = " ";
            _testSpacesReplaced(str);
        }

        private void _testSpacesReplaced(string str)
        {
            var initialLength = str.Length;

            var numberOfSpaces = str.Where(c => c == ' ').Count();

            char[] charArray = new char[initialLength + (numberOfSpaces * 2)];

            str.CopyTo(0, charArray, 0, initialLength);

            Q4.ReplaceSpacesInPlace(charArray, initialLength);

            var resultString = new string(charArray);

            Assert.AreEqual(str.Replace(" ", "%20"), resultString);

            Console.WriteLine($"Input: \"{str}\"");
            Console.WriteLine($"Output: \"{resultString}\"");
        }
    }
}
