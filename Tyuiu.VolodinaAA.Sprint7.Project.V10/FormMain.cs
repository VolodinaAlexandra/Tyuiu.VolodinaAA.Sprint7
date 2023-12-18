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


        private void buttonGoToOrder_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonBuy_VAA.BackColor = Color.AliceBlue;
        }

        private void buttonGoToOrder_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonBuy_VAA.BackColor = Color.White;
        }

        private void buttonInformation_VAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonInstruction_VAA_Click(object sender, EventArgs e)
        {
            FormInstruction formInstruction = new FormInstruction();
            formInstruction.ShowDialog();
        }

        private void buttonStatistic_VAA_Click(object sender, EventArgs e)
        {
            FormStatistic formStatistic = new FormStatistic();
            formStatistic.ShowDialog();
        }

        private void buttonAuthorise_VAA_Click(object sender, EventArgs e)
        {
            FormAuthorise formAuthorise = new FormAuthorise();
            formAuthorise.ShowDialog();
        }
    }
}
