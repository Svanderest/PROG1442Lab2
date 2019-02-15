
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]        
        public void TestMethod1()
        {
            Math.Log(-1);

            Assert.Fail();
        }
    }
}
