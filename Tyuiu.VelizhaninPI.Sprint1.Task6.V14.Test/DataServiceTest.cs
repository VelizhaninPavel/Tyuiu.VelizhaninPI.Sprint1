using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint1.Task6.V14.Lib;

namespace Tyuiu.VelizhaninPI.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string strtest = "ПРИВЕТ МИР";
            Boolean res = ds.CheckLowerCaseRusLetters(strtest);
            Boolean wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
