using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint1.Task5.V4.Lib;

namespace Tyuiu.VelizhaninPI.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 13257;

            DataService ds = new DataService();

            double res = ds.SecondsToHours(k);
            int result = Convert.ToInt32(res);
            Assert.AreEqual(3, result);
        }
    }
}
