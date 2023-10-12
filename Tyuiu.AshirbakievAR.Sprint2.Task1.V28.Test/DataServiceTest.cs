using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint2.Task1.V28.Lib;

namespace Tyuiu.AshirbakievAR.Sprint2.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetLogicOperationsTest()
        {
            DataService ds = new DataService();
            bool[] wait = new bool[6] { true, false, true, false, true, false };
            int a = 247, b = 654, c = 671, d = 671;
            CollectionAssert.AreEqual(wait, ds.GetLogicOperations(a, b, c, d));
        }
    }
}
