using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ylesanne1_2;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var p = new Point(1, 1);
            Assert.IsNotNull(p);

        }
    }
}
