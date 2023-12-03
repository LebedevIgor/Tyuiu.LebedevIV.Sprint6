using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint6.Task0.V18.Lib;

namespace Tyuiu.LebedevIV.Sprint6.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1);
            double wait = -3.5;
            Assert.AreEqual(wait, res);
        }
    }
}
