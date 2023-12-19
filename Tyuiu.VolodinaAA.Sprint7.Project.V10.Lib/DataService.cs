using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.VolodinaAA.Sprint7.Project.V10.Lib
{
    public class DataService
    {
        public Dictionary<string, int> CountCities(string path)
        {
            Dictionary<string, int> cityCount = new Dictionary<string, int>();
            path = $@"{Directory.GetCurrentDirectory()}\Данные Пользователей.csv";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while((line = sr.ReadLine())!=null)
                {
                    string[] data = line.Split(';');
                    if (data.Length >= 5)
                    {
                        string city = data[4].Trim();
                        if (cityCount.ContainsKey(city))
                        {
                            cityCount[city]++;
                        }
                        else
                        {
                            cityCount[city] = 1;
                        }
                    }
                }
            }
            return cityCount;
        }
    }
}
