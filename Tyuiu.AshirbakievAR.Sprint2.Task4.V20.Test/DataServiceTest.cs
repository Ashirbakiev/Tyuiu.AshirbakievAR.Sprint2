using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint2.Task4.V20.Lib;

namespace Tyuiu.AshirbakievAR.Sprint2.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(8,ds.Calculate(2,1));
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            Assert.AreEqual(3.9, ds.Calculate(2, 10));
        }
    }
}
