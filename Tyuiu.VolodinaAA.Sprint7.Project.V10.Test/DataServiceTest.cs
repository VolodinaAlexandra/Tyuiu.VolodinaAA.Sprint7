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
        [TestMethod]
        public void CheckThingsDataCollectionValid()
        {
            ThingsDataCollection td = new ThingsDataCollection();

            var thingsData = new ThingsData { Thing = "Ёлочная игрушка Ангелочки", Sales = 350 }; ;

            Assert.IsNotNull(thingsData);
            Assert.AreEqual("Ёлочная игрушка Ангелочки", thingsData.Thing);
            Assert.AreEqual(350, thingsData.Sales);
        }
        [TestMethod]
        public void CheckGetPriceForItemValid()
        {
            SummItem si = new SummItem();

            string item = "Ёлочная игрушка Избушка";
            int res = si.GetPriceForItem(item);
            int wait = 150;
            Assert.AreEqual(wait,res);
        }
    }
}
