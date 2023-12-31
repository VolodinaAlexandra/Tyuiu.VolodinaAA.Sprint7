﻿using System;
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
        private List<string> selectedItems = new List<string>();
        public string TotalAmount
        {
            get { return textBoxItogo_VAA.Text; }
        }
        public string DateTimeValue
        {
            get { return dateTimePickerOrderEnd_VAA.Text; }
        }
        public FormPersonalCabinet()
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
            captions.Add("Ёлочная игрушка \nЛуна");
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

            for (int i = 0; i < checkedListBoxItems_VAA.CheckedItems.Count; i++)
            {
                string item = checkedListBoxItems_VAA.CheckedItems[i].ToString();
                double price = si.GetPriceForItem(item);

                totalSum += price;
            }

            textBoxItogo_VAA.Text = totalSum.ToString();
        }

        private void buttonEndofOrder_VAA_Click(object sender, EventArgs e)
        {
            foreach (string item in checkedListBoxItems_VAA.CheckedItems)
            {
                selectedItems.Add(item);
            }
            

            FormMyOrders mo = new FormMyOrders(selectedItems,TotalAmount,DateTimeValue);
            mo.Show();
            
        }

        private void FormPersonalCabinet_Load(object sender, EventArgs e)
        {
            dateTimePickerOrderEnd_VAA.MinDate = DateTime.Today;
        }

        private void buttonNext_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonNext_VAA.BackColor = Color.LimeGreen;
        }

        private void buttonNext_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonNext_VAA.BackColor = Color.White;
        }

        private void buttonPrevious_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonPrevious_VAA.BackColor = Color.LimeGreen;
        }

        private void buttonPrevious_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonPrevious_VAA.BackColor = Color.White;
        }

        private void buttonItogo_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonItogo_VAA.BackColor = Color.Green;
        }

        private void buttonItogo_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonItogo_VAA.BackColor = Color.White;
        }

        private void buttonEndofOrder_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonEndofOrder_VAA.BackColor = Color.Coral;
        }

        private void buttonEndofOrder_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonEndofOrder_VAA.BackColor = Color.White;
        }
    }
}
