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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void buttonNext_VAA_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите сохранить ваши данные?", "!", MessageBoxButtons.YesNoCancel);

            if (dialogResult == DialogResult.Yes)
            {
                
                FormOrderInfo formOrderInfo = new FormOrderInfo();
                formOrderInfo.ShowDialog();

                string path = $@"{Directory.GetCurrentDirectory()}\Данные Пользователей.csv";
                
                using (StreamWriter streamWriter = new StreamWriter(path,true, Encoding.Default))
                {
                    string surname = textBoxSurname_VAA.Text;
                    string name = textBoxName_VAA.Text;
                    string patronymic = textBoxPatronymic_VAA.Text;
                    string phoneNumber = maskedTextBoxPhoneNumber_VAA.Text;
                    string data = $"{surname};{name};{patronymic};{phoneNumber}";
                    streamWriter.WriteLine(data);
                    streamWriter.Close();
                }
                

            }
        }
    }
}
