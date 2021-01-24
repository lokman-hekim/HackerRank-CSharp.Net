using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesByMatch;

namespace TestProject
{
    [TestClass]
    public class UTSalesByMatch
    {
        [TestMethod]
        public void TestMethod1()
        {
            int sockNumber = 9;
            int[] colors = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int expected = 3;
            int retVal = Program.sockMerchant(sockNumber, colors);
            Assert.AreEqual(expected, retVal);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int sockNumber = 12;
            int[] colors = { 10, 20, 20, 10, 10, 30, 50, 10, 20, 20, 50, 10 };
            int expected = 5;
            int retVal = Program.sockMerchant(sockNumber, colors);
            Assert.AreEqual(expected, retVal);
        }
    }
}
