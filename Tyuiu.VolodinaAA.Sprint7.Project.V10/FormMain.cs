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
            images.Add(Image.FromFile(@"C:\Users\Александра\Pictures\shelkunchiki.jpg"));
            images.Add(Image.FromFile(@"C:\Users\Александра\Pictures\house.jpg"));
            images.Add(Image.FromFile(@"C:\Users\Александра\Pictures\matreshka.jpg"));


            captions.Add("Ёлочная игрушка \nАнгелочки");
            captions.Add("Набор ёлочных \nигрушек");
            captions.Add("Ёлочная игрушка \nПолумесяц");
            captions.Add("Ёлочная игрушка \nБантик");
            captions.Add("Ёлочная игрушка \nЩелкунчик");
            captions.Add("Ёлочная игрушка \nИзбушка");
            captions.Add("Ёлочная игрушка \nМатрёшка");

            price.Add("450 руб.");
            price.Add("650 руб.");
            price.Add("150 руб.");
            price.Add("250 руб.");
            price.Add("350 руб.");
            price.Add("150 руб.");
            price.Add("250 руб.");

            pictureBoxToys_VAA.Image = images[currentIndex];
            labelCapture_VAA.Text = captions[currentIndex];
            labelPrice_VAA.Text = price[currentIndex];
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
            buttonBuy_VAA.Enabled = true; 
        }

        private void buttonBuy_VAA_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder();
            formOrder.ShowDialog();
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

        private void buttonBuy_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonBuy_VAA.BackColor = Color.Green;
        }

        private void buttonBuy_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonBuy_VAA.BackColor = Color.White;
        }

        private void buttonAuthorise_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonAuthorise_VAA.BackColor = Color.Red;
        }

        private void buttonAuthorise_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonAuthorise_VAA.BackColor = Color.White;
        }

        private void buttonStatistic_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonStatistic_VAA.BackColor = Color.Yellow;
        }

        private void buttonStatistic_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonStatistic_VAA.BackColor = Color.White;
        }

        private void buttonInformation_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonInformation_VAA.BackColor = Color.SkyBlue;
        }

        private void buttonInformation_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonInformation_VAA.BackColor = Color.White;
        }

        private void buttonInstruction_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonInstruction_VAA.BackColor = Color.Pink;
        }

        private void buttonInstruction_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonInstruction_VAA.BackColor = Color.White;
        }

        private void buttonNextPicture_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonNextPicture_VAA.BackColor = Color.LimeGreen;
        }

        private void buttonNextPicture_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonNextPicture_VAA.BackColor = Color.White;
        }

        private void buttonPreviousPicture_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonPreviousPicture_VAA.BackColor = Color.LimeGreen;
        }

        private void buttonPreviousPicture_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonPreviousPicture_VAA.BackColor = Color.White;
        }
    }
}
