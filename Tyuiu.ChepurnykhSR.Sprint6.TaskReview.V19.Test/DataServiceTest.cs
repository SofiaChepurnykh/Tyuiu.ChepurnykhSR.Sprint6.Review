using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChepurnykhSR.Sprint6.TaskReview.V19.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint6.TaskReview.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            int[,] mas1 = new int[5, 5] { { 3, 1, 4, 8, 1 },
                                          { 3, 2, 4, 9, 6 },
                                          { 1, 6, 4, 4, 3 },
                                          { 3, 5, 1, 6, 9 },
                                          { 3, 2, 4, 2, 5 } };

            int res = ds.GetMatrix(mas1, 1, 1, 5);

            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}
