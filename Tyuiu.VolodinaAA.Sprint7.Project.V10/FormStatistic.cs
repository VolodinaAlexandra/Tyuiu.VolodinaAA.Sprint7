using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VolodinaAA.Sprint7.Project.V10.Lib;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.VolodinaAA.Sprint7.Project.V10.Lib;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.VolodinaAA.Sprint7.Project.V10
{
    public partial class FormStatistic : Form
    {
        
        SalesData sd = new SalesData();
        private SalesDataCollection salesDataCollection;

        ThingsData td = new ThingsData();
        private ThingsDataCollection thingsDataCollection;

        public FormStatistic()
        {
            InitializeComponent();
            salesDataCollection = new SalesDataCollection();
            thingsDataCollection = new ThingsDataCollection();
        }

        private void buttonSales_VAA_Click(object sender, EventArgs e)
        {
            SalesDataCollection sd = new SalesDataCollection();

            chartStatistic_VAA.Series.Clear();

            Series salesSeries = new Series("Продажи");
            salesSeries.ChartType = SeriesChartType.Bar;

            foreach (SalesData salesData in sd)
            {
                salesSeries.Points.AddXY(salesData.Month, salesData.Sales);
            }

            chartStatistic_VAA.Series.Add(salesSeries);
        }
        
        private void buttonPopularThings_VAA_Click(object sender, EventArgs e)
        {
            ThingsDataCollection td = new ThingsDataCollection();
            chartStatistic_VAA.Series.Clear();
            Series salesSeries = new Series("Продажи");
            salesSeries.ChartType = SeriesChartType.Bar;
            foreach (ThingsData thingsData in td)
            {
                salesSeries.Points.AddXY(thingsData.Thing, thingsData.Sales);
            }
            chartStatistic_VAA.Series.Add(salesSeries);
        }

        private void buttonSales_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonSales_VAA.BackColor = Color.Green;
        }

        private void buttonSales_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonSales_VAA.BackColor = Color.White;
        }

        private void buttonPopularThings_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonPopularThings_VAA.BackColor = Color.LightGreen;
        }

        private void buttonPopularThings_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonPopularThings_VAA.BackColor = Color.White;
        }
    }
}
