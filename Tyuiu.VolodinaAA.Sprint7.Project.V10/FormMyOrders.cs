using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                labelListOfOrders_VAA.Text += item + ",\n";
            }
        }

        private void buttonGoToMenu_VAA_Click(object sender, EventArgs e)
        {
            FormMain fm = new FormMain();
            fm.ShowDialog();
            this.Hide();
        }
    }
}
