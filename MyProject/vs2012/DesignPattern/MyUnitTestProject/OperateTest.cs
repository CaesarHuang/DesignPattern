using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPattern.SimpleFactoryDL;

namespace MyUnitTestProject
{
    [TestClass]
    public class OperateTest
    {
        [TestMethod]
        public void AddTest()
        {
            Operation testUnit = new AddOperate();
            testUnit.NumberA = 4;
            testUnit.NumberB = 0;
            Assert.AreEqual(testUnit.GetResult(), 4);
        }

        [TestMethod]
        public void MinusTest()
        {
            Operation testUnit = new MinusOperate();
            testUnit.NumberA = 4;
            testUnit.NumberB = 1;
            Assert.AreEqual(testUnit.GetResult(), 3);
        }

        [TestMethod]
        public void DivisionTest()
        {
            Operation testUnit = new DivisionOperate();
            testUnit.NumberA = 4;
            testUnit.NumberB = 2;
            Assert.AreEqual(testUnit.GetResult(), 2);
        }
    }
}
