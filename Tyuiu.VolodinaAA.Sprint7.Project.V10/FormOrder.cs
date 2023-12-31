﻿using System;
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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();

            comboBoxTowns_VAA.SelectedIndexChanged += comboBoxTowns_VAA_SelectedIndexChanged;
            textBoxPostIndex_VAA.KeyPress += new KeyPressEventHandler(textBoxPostIndex_VAA_KeyPress);
        }
        void comboBoxTowns_VAA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBoxTowns_VAA.SelectedItem.ToString();
        }
        private void buttonNext_VAA_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите сохранить ваши данные?", "!", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                

                string path = $@"{Directory.GetCurrentDirectory()}\Данные Пользователей.csv";
                
                using (StreamWriter streamWriter = new StreamWriter(path,true, Encoding.Default))
                {
                    string surname = textBoxSurname_VAA.Text;
                    string name = textBoxName_VAA.Text;
                    string patronymic = textBoxPatronymic_VAA.Text;
                    string phoneNumber = maskedTextBoxPhoneNumber_VAA.Text;
                    string selectedState = comboBoxTowns_VAA.SelectedItem.ToString();
                    string postIndex = textBoxPostIndex_VAA.Text;
                    string adress = textBoxAdress_VAA.Text;
                    string data = $"{surname};{name};{patronymic};{phoneNumber};{selectedState};{postIndex};{adress}";
                    streamWriter.WriteLine(data);
                    streamWriter.Close();
                }
                FormPersonalCabinet pc = new FormPersonalCabinet();
                pc.ShowDialog();
                this.Hide();
                

            }

        }

        private void checkBoxCondition_VAA_CheckedChanged(object sender, EventArgs e)
        {
            buttonEnd_VAA.Enabled = true;
        }

        private void buttonGoBack_VAA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPostIndex_VAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && textBoxPostIndex_VAA.Text.Length == 6 && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonEnd_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonEnd_VAA.BackColor = Color.Coral;
        }

        private void buttonEnd_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonEnd_VAA.BackColor = Color.White;
        }
    }
}
