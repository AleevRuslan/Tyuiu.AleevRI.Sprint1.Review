using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AleevRI.Sprint1.Review.V8.Lib;

namespace Tyuiu.AleevRI.Sprint1.Review.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = -2.308;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}
