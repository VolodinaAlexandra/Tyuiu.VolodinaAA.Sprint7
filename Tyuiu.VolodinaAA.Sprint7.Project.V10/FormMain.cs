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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGoToOrder_VAA_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder();
            formOrder.ShowDialog();
        }

        private void buttonGoToOrder_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonGoToOrder_VAA.BackColor = Color.AliceBlue;
        }

        private void buttonGoToOrder_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonGoToOrder_VAA.BackColor = Color.White;
        }
    }
}
