using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeTest;

namespace UnitTest
{
    // Test class for TDD
    [TestClass]
    public class UnitTest1
    {
        // Test method for MilkChoco class
        [TestMethod]
        public void TestMilkMethod()
        {
            MilkChoco obj = new CodeTest.MilkChoco("milk", 12, 2, 5);
            int result = obj.getMilk();
            Assert.AreEqual(7, result);
            result = obj.getDark();
            Assert.AreEqual(0, result);
            result = obj.getWhite();
            Assert.AreEqual(0, result);
        }

        // Test method for DarkChoco class
        [TestMethod]
        public void TestDarkMethod()
        {
            DarkChoco obj = new CodeTest.DarkChoco("dark", 13, 4, 1);
            int result = obj.getMilk();
            Assert.AreEqual(0, result);
            result = obj.getDark();
            Assert.AreEqual(9, result);
            result = obj.getWhite();
            Assert.AreEqual(0, result);
        }

        // Test method for DarkChoco class
        [TestMethod]
        public void TestWhiteMethod()
        {
            WhiteChoco obj = new CodeTest.WhiteChoco("white", 6, 2, 2);
            int result = obj.getMilk();
            Assert.AreEqual(1, result);
            result = obj.getDark();
            Assert.AreEqual(0, result);
            result = obj.getWhite();
            Assert.AreEqual(4, result);
        }
    }
}
