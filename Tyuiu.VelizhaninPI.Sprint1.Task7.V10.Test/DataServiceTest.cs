using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint1.Task7.V10.Lib;

namespace Tyuiu.VelizhaninPI.Sprint1.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 1;
            var res = ds.Calculate(x);
            var wait = -13.142;
            Assert.AreEqual(wait, res);

        }
    }
}
