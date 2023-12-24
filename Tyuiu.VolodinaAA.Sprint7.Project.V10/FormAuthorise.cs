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
    public partial class FormAuthorise : Form
    {
        public FormAuthorise()
        {
            InitializeComponent();
            textBoxLogin_VAA.KeyPress += new KeyPressEventHandler(textBoxLogin_VAA_KeyPress);
            textBoxPassword_VAA.KeyPress += new KeyPressEventHandler(textBoxPassword_VAA_KeyPress);
        }


        private void buttonContinue_VAA_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите сохранить ваши данные?", "!", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                string path = $@"{Directory.GetCurrentDirectory()}\Данные паролей.csv";

                using (StreamWriter streamWriter = new StreamWriter(path, true, Encoding.Default))
                {
                    string login = textBoxLogin_VAA.Text;
                    string password = textBoxPassword_VAA.Text;
                    string data = $"{login};{password}";
                    streamWriter.WriteLine(data);
                    streamWriter.Close();
                }
                
                this.Close();
            }
            
        }

        private void textBoxLogin_VAA_TextChanged(object sender, EventArgs e)
        {
            UpdateContinueButtonState();
        }

        private void textBoxPassword_VAA_TextChanged(object sender, EventArgs e)
        {
            UpdateContinueButtonState();
        }
        private void UpdateContinueButtonState()
        {
            bool isLoginEmpty = string.IsNullOrWhiteSpace(textBoxLogin_VAA.Text);
            bool isPasswordEmpty = string.IsNullOrWhiteSpace(textBoxPassword_VAA.Text);

            buttonContinue_VAA.Enabled = !isLoginEmpty && !isPasswordEmpty;
        }

        private void textBoxLogin_VAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }

            if (textBoxLogin_VAA.Text.Length >= 16 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBoxPassword_VAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }

            if (textBoxPassword_VAA.Text.Length == 8 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void buttonContinue_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonContinue_VAA.BackColor = Color.Coral;
        }

        private void buttonContinue_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonContinue_VAA.BackColor = Color.White;
        }
    }
}
