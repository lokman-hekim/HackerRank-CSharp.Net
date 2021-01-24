using System;
using System.Collections.Generic;
using MaximumCostOfLaptopCount;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UTMaximumCostOfLaptop
    {
        [TestMethod]
        public void TestMethod1()
        {
            int dailyCount = 1;
            List<int> cost = new List<int>();
            cost.Add(0);
            cost.Add(3);
            cost.Add(2);
            cost.Add(3);
            cost.Add(4);
            List<string> labels = new List<string>();
            labels.Add("legal");
            labels.Add("legal");
            labels.Add("illegal");
            labels.Add("legal");
            labels.Add("legal");
            int result = Result.maxCost(cost, labels,dailyCount);
            int expected = 5;

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int dailyCount = 1;
            List<int> cost = new List<int>();
            cost.Add(2);
            
            List<string> labels = new List<string>();
            labels.Add("illegal");
            
            int result = Result.maxCost(cost, labels, dailyCount);
            int expected = 0;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int dailyCount = 2;
            List<int> cost = new List<int>();
            cost.Add(2);
            cost.Add(5);
            cost.Add(3);
            cost.Add(11);
            cost.Add(1);
            List<string> labels = new List<string>();
            labels.Add("legal");
            labels.Add("illegal");
            labels.Add("legal");
            labels.Add("illegal");
            labels.Add("legal"); ;

            int result = Result.maxCost(cost, labels, dailyCount);
            int expected = 10;

            Assert.AreEqual(expected, result);
        }
    }
}
