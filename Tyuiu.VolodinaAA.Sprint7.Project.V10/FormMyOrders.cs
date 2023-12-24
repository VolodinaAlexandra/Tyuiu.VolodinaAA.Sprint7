using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tyuiu.VolodinaAA.Sprint7.Project.V10
{
    public partial class FormMyOrders : Form
    {
        
        public FormMyOrders(List<string> selectedItems,string TotalAmount, string DateTimeValue)
        {
            InitializeComponent();
            labelTotalAmount_VAA.Text = TotalAmount;
            labelDateTimeValue_VAA.Text = DateTimeValue;
            foreach (string item in selectedItems)
            {
                labelListOfOrders_VAA.Text += item + ",";
            }
        }

        private void buttonGoToMenu_VAA_Click(object sender, EventArgs e)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\Заказы.csv";

            using (StreamWriter streamWriter = new StreamWriter(path, true, Encoding.Default))
            {
                string order = labelListOfOrders_VAA.Text;
                string price = labelTotalAmount_VAA.Text;
                string date = labelDateTimeValue_VAA.Text;
               ;
                string data = $"{order};{price};{date}";
                streamWriter.WriteLine(data);
                streamWriter.Close();
            }
            
            this.Hide();
        }

        private void buttonGoToMenu_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonGoToMenu_VAA.BackColor = Color.Coral;
        }

        private void buttonGoToMenu_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonGoToMenu_VAA.BackColor = Color.White;
        }
    }
}
