using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint6.TaskReview.V9.Lib;

namespace Tyuiu.KrutikovaVP.Sprint6.TaskReview.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            int k = 0;
            int l = 2;
            int c = 0;
            DataService ds = new DataService();
            int[,] array = new int[4, 4]  { { 4, -3, 6, -5},
                                            { 3, -4, 6, -6},
                                            { 6, -4, 6, -4 },
                                            { 5, -4, 4, -4 }};
            int res = ds.resultGetMatrix(array, c, k, l);
            int wait = 24;
            Assert.AreEqual(wait, res);
        }
    }
}
