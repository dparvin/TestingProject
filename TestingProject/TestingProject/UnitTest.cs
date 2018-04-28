
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForTrue()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void TestForFalse()
        {
            Assert.IsFalse(false);
        }
    }
}
