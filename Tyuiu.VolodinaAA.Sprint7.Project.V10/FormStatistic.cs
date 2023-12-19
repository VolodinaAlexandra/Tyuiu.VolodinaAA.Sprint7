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

namespace Tyuiu.VolodinaAA.Sprint7.Project.V10
{
    public partial class FormStatistic : Form
    {
        private Dictionary<string, int> countCities;
        DataService ds = new DataService();

        public FormStatistic()
        {
            InitializeComponent();
        }

        private void buttonDone_VAA_Click(object sender, EventArgs e)
        {
           //
        }

        private void buttonPopularTowns_VAA_Click(object sender, EventArgs e)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\Данные Пользователей.csv";
            countCities = ds.CountCities(path);
            try
            {
                if (radioButtonTablitsa_VAA.Checked)
                {
                    ShowDataInDataGridView();
                }
                else if (radioButtonDiagram_VAA.Checked)
                {
                    ShowDataInChart();
                }
            }
            catch
            {
                MessageBox.Show("Произошел свой в программе, повторите попытку", "Ошибка выведения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowDataInDataGridView()
        {
            dataGridViewStatistic_VAA.Rows.Clear();
            foreach (var city in countCities)
            {
                dataGridViewStatistic_VAA.Rows.Add(city.Key, city.Value);
            }
        }
        private void ShowDataInChart()
        {
            chartStatistic_VAA.Series.Clear();
            var series = new Series()
            {
                ChartType = SeriesChartType.Column
            };
            foreach (var city in countCities)
            {
                series.Points.AddXY(city.Key, city.Value);
            }
            chartStatistic_VAA.Series.Add(series);
        }

        
    }
}
