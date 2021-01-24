using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepeatedString;

namespace TestProject
{
    [TestClass]
    public class UTRepeatedString
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 10;
            string s = "aba";
            long result = Program.repeatedString(s, n);
            long expected = 7;

            Assert.AreEqual(expected, result);
        }
    }
}
