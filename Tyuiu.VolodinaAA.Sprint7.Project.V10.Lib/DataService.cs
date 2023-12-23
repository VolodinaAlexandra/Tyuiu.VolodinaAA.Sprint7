using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.VolodinaAA.Sprint7.Project.V10.Lib
{
    public class SalesData
    {
        public string Month { get; set; }
        public int Sales { get; set; }
    }
    public class ThingsData
    {
        public string Thing { get; set; }
        public int Sales { get; set; }
    }
    public class SalesDataCollection : List<SalesData>
    {
        public SalesDataCollection()
        {
            Add(new SalesData { Month = "Январь", Sales = 1508 });
            Add(new SalesData { Month = "Февраль", Sales = 150 });
            Add(new SalesData { Month = "Март", Sales = 102 });
            Add(new SalesData { Month = "Апрель", Sales = 14 });
            Add(new SalesData { Month = "Май", Sales = 18 });
            Add(new SalesData { Month = "Июнь", Sales = 10 });
            Add(new SalesData { Month = "Июль", Sales = 12 });
            Add(new SalesData { Month = "Август", Sales = 21 });
            Add(new SalesData { Month = "Сентябрь", Sales = 120 });
            Add(new SalesData { Month = "Октябрь", Sales = 356 });
            Add(new SalesData { Month = "Ноябрь", Sales = 2100 });
            Add(new SalesData { Month = "Декабрь", Sales = 2536 });
        }

    }
    public class ThingsDataCollection: List<ThingsData>
    {
        public ThingsDataCollection()
        {
            Add(new ThingsData { Thing = "Ёлочная игрушка Ангелочки", Sales = 3500 });
            Add(new ThingsData { Thing = "Набор ёлочных игрушек", Sales = 1645 });
            Add(new ThingsData { Thing = "Ёлочная игрушка Луна", Sales =  485});
            Add(new ThingsData { Thing = "Ёлочная игрушка Бантик", Sales = 1204 });
        }
    }
    public class SummItem
    {
        public int GetPriceForItem(string item)
        {
            switch (item)
            {
                case "Ёлочная игрушка Ангелочки":
                    return 450;
                case "Набор ёлочных игрушек":
                    return 650;
                case "Ёлочная игрушка Луна":
                    return 150;
                case "Ёлочная игрушка Бантик":
                    return 250;
                default:
                    return 0;
            }
        }
    }
    
}
