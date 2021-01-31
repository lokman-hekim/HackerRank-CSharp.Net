using System;
using Hash_Tables_Ransom_Note;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UTHashTablesRansomNote
    {
        [TestMethod]
        public void TestMethod1()
        {
            string magazine = "give me one grand today night";
            string note = "give one grand today";
            string result = Program.checkMagazine(magazine.Split(' '), note.Split(' '));
            string expected = "Yes";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string magazine = "two times three is not four";
            string note = "two times two is four";
            string result = Program.checkMagazine(magazine.Split(' '), note.Split(' '));
            string expected = "No";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string magazine = "ive got a lovely bunch of coconuts";
            string note = "ive got some coconuts";
            string result = Program.checkMagazine(magazine.Split(' '), note.Split(' '));
            string expected = "No";

            Assert.AreEqual(expected, result);
        }
    }
}
