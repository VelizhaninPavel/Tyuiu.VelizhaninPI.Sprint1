using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint1.Task4.V27.Lib;

namespace Tyuiu.VelizhaninPI.Sprint1.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-4.236 , res);
        }
    }
}
