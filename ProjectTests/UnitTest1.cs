using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectLibrary;

namespace ProjectTests
{
    /// <summary>
    /// the sinplest verification unit test for example
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Actions action = new Actions(new Data(0, 0));
            double expected = 0;
            double actual = action.Calculation();
            Assert.AreEqual(0, 0);
        }
    }
}
