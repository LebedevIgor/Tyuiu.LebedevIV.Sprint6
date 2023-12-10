using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Tyuiu.LebedevIV.Sprint6.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Igor\source\repos\Tyuiu.LebedevIV.Sprint6\Tyuiu.LebedevIV.Sprint6.Task7.V10\bin\Debug\InPutFileTask7V10.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
