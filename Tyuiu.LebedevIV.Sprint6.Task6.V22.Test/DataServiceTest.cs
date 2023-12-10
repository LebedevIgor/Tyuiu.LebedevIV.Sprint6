using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;


namespace Tyuiu.LebedevIV.Sprint6.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Igor\source\repos\Tyuiu.LebedevIV.Sprint6\Tyuiu.LebedevIV.Sprint6.Task6.V22\bin\Debug\InPutFileTask6V22.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
