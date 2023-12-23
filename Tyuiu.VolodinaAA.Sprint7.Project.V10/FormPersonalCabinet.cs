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

namespace Tyuiu.VolodinaAA.Sprint7.Project.V10
{
    public partial class FormPersonalCabinet : Form
    {
        private int currentIndex = 0;
        private List<Image> images = new List<Image>();
        private List<string> captions = new List<string>();
        private List<string> price = new List<string>();
        public FormPersonalCabinet()
        {
            InitializeComponent();
            images.Add(Image.FromFile(@"C:\Users\Александра\Pictures\images.jpg"));
            images.Add(Image.FromFile(@"C:\Users\Александра\Pictures\things.jpg"));
            images.Add(Image.FromFile(@"C:\Users\Александра\Pictures\moon.jpg"));
            images.Add(Image.FromFile(@"C:\Users\Александра\Pictures\bantik.jpg"));

            captions.Add("Ёлочная игрушка \nАнгелочки");
            captions.Add("Набор ёлочных \nигрушек");
            captions.Add("Ёлочная игрушка \nЛуна");
            captions.Add("Ёлочная игрушка \nБантик");

            price.Add("450 руб.");
            price.Add("650 руб.");
            price.Add("150 руб.");
            price.Add("250 руб.");

            pictureBoxImages_VAA.Image = images[currentIndex];
            labelCapture_VAA.Text = captions[currentIndex];
            labelPrice_VAA.Text = price[currentIndex];
        }

        private void buttonNext_VAA_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= images.Count)
            {
                currentIndex = 0;
            }
            pictureBoxImages_VAA.Image = images[currentIndex];
            labelCapture_VAA.Text = captions[currentIndex];
            labelPrice_VAA.Text = price[currentIndex];
        }

        private void buttonPrevious_VAA_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = images.Count - 1;
            }
            pictureBoxImages_VAA.Image = images[currentIndex];
            labelCapture_VAA.Text = captions[currentIndex];
            labelPrice_VAA.Text = price[currentIndex];
        }

        private void buttonItogo_VAA_Click(object sender, EventArgs e)
        {
            SummItem si = new SummItem();

            double totalSum = 0;

            // Проходим по всем выбранным элементам CheckedListBox
            for (int i = 0; i < checkedListBoxItems_VAA.CheckedItems.Count; i++)
            {
                string item = checkedListBoxItems_VAA.CheckedItems[i].ToString();
                double price = si.GetPriceForItem(item);

                totalSum += price;
            }

            // Выводим общую сумму в TextBox
            textBoxItogo_VAA.Text = totalSum.ToString();
        }
    }
}
