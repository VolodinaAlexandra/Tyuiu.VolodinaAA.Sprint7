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
        private List<string> selectedItems;
        public FormMyOrders(List<string> selectedItems)
        {
            InitializeComponent();
            this.selectedItems = selectedItems;
        }

        private void FormMyOrders_Load(object sender, EventArgs e)
        {
            labelListOfOrders_VAA.Text = string.Join("\n", selectedItems);
        }
    }
}
