﻿using Tyuiu.MarkovSE.Sprint4.Task1.V12.Lib;
namespace Tyuiu.MarkovSE.Sprint4.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int[] array = [4, 8, 6, 4, 9, 5, 8, 7, 8, 4, 7, 6, 8];
            Assert.AreEqual(2205, ds.Calculate(array));
        }
    }
}