using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.LebedevIV.Sprint6.Task5.V1.Lib;


namespace Tyuiu.LebedevIV.Sprint6.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Igor\source\repos\Tyuiu.LebedevIV.Sprint6\Tyuiu.LebedevIV.Sprint6.Task5.V1\bin\Debug\InPutFileTask5V1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
