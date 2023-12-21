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
        private int currentIndex = 0;
        private List<Image> images = new List<Image>();
        private List<string> captions = new List<string>();
        private List<string> price = new List<string>();
        public FormMain()
        {
            InitializeComponent();
            images.Add(Image.FromFile(@"C:\Users\Александра\Pictures\images.jpg"));
            images.Add(Image.FromFile(@"C:\Users\Александра\Pictures\things.jpg"));
            images.Add(Image.FromFile(@"C:\Users\Александра\Pictures\moon.jpg"));
            images.Add(Image.FromFile(@"C:\Users\Александра\Pictures\bantik.jpg"));

            captions.Add("Ёлочная игрушка Ангелочки");
            captions.Add("Набор ёлочных игрушек");
            captions.Add("Ёлочная игрушка Луна");
            captions.Add("Ёлочная игрушка Бантик");

            price.Add("450 руб.");
            price.Add("650 руб.");
            price.Add("150 руб.");
            price.Add("250 руб.");

            pictureBoxToys_VAA.Image = images[currentIndex];
            labelCapture_VAA.Text = captions[currentIndex];
            labelPrice_VAA.Text = price[currentIndex];
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

        private void buttonBuy_VAA_Click(object sender, EventArgs e)
        {
            FormPersonalCabinet personalCabinet = new FormPersonalCabinet();
            personalCabinet.ShowDialog();
        }

        private void buttonNextPicture_VAA_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= images.Count)
            {
                currentIndex = 0;
            }
            pictureBoxToys_VAA.Image = images[currentIndex];
            labelCapture_VAA.Text = captions[currentIndex];
            labelPrice_VAA.Text = price[currentIndex];
        }

        private void buttonPreviousPicture_VAA_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = images.Count - 1;
            }
            pictureBoxToys_VAA.Image = images[currentIndex];
            labelCapture_VAA.Text = captions[currentIndex];
            labelPrice_VAA.Text = price[currentIndex];
        }
    }
}
