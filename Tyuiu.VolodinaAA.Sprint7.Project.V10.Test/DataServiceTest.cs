using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint7.Project.V10.Lib;

namespace Tyuiu.VolodinaAA.Sprint7.Project.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSalesDataCollectionValid()
        {
            SalesDataCollection sd = new SalesDataCollection();

            var salesData = new SalesData { Month = "Май", Sales = 18 }; ;

            Assert.IsNotNull(salesData);
            Assert.AreEqual("Май", salesData.Month);
            Assert.AreEqual(18, salesData.Sales);
        }

    }
}
