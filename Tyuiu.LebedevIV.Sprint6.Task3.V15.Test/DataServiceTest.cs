using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint6.Task3.V15.Lib;

namespace Tyuiu.LebedevIV.Sprint6.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                { 33, 28, 31, 19, 4 },
                { 1, 32, -3, -17, -12 },
                { 24, -19, 26, 31, -3 },
                { 30, -16, 29, 28, 8 },
                { 30, 5, 11, 7, 32 }
            };

            int[,] expected = {
                { 1, 32, -3, -17, -12 },
                { 30, 5, 11, 7, 32 },
                { 24, -19, 26, 31, -3 },
                { 30, -16, 29, 28, 8 },
                { 33, 28, 31, 19, 4 }
            };

            // Act
            int[,] result = ds.Calculate(matrix);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
