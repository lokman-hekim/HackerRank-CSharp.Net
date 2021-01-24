using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountingValleys;

namespace TestProject
{
    [TestClass]
    public class UTCountingValley
    {
        [TestMethod]
        public void TestMethod1()
        {
            int steps = 8;
            string path = "UDDDUDUU";
            int valleys = Program.countingValleys(steps, path);
            int expected = 1;

            Assert.AreEqual(expected, valleys);


        }
        [TestMethod]
        public void TestMethod2()
        {
            int steps = 12;
            string path = "DDUUDDUDUUUD";
            int valleys = Program.countingValleys(steps, path);
            int expected = 2;

            Assert.AreEqual(expected, valleys);


        }
    }
}
