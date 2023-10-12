using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint2.Task2.V10.Lib;

namespace Tyuiu.AshirbakievAR.Sprint2.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedAreaTest()
        {
            DataService ds = new DataService();
            int x = 8, y = 7;
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
    }
}
