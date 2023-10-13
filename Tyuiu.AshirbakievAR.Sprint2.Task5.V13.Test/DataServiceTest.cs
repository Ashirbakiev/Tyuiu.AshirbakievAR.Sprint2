using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint2.Task5.V13.Lib;

namespace Tyuiu.AshirbakievAR.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0, ds.FindDateOfNextDay(1000, 31, 321));
            Assert.AreEqual(20240301, ds.FindDateOfNextDay(2024, 2, 29));
        }
    }
}
