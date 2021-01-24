using System;
using JumpingOnTheClouds;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UTJumpingOnTheClouds
    {
        [TestMethod]
        public void TestMethod1()
        {

            string clouds = "0 0 1 0 0 1 0";
            int[] c = Array.ConvertAll(clouds.Split(' '), cTemp => Convert.ToInt32(cTemp));
            int expected = 4;
            int retVal = Program.jumpingOnClouds(c);
            Assert.AreEqual(expected, retVal);
            
        }

        [TestMethod]
        public void TestMethod2()
        {

            string clouds = "0 0 0 0 1 0";
            int[] c = Array.ConvertAll(clouds.Split(' '), cTemp => Convert.ToInt32(cTemp));
            int expected = 3;
            int retVal = Program.jumpingOnClouds(c);
            Assert.AreEqual(expected, retVal);

        }
        [TestMethod]
        public void TestMethod3()
        {

            string clouds = "0 1 0 0 0 1 0";
            int[] c = Array.ConvertAll(clouds.Split(' '), cTemp => Convert.ToInt32(cTemp));
            int expected = 3;
            int retVal = Program.jumpingOnClouds(c);
            Assert.AreEqual(expected, retVal);

        }

        [TestMethod]
        public void TestMethod4()
        {

            string clouds = "0 0 0 1 0 0";
            int[] c = Array.ConvertAll(clouds.Split(' '), cTemp => Convert.ToInt32(cTemp));
            int expected = 3;
            int retVal = Program.jumpingOnClouds(c);
            Assert.AreEqual(expected, retVal);

        }
    }
}
