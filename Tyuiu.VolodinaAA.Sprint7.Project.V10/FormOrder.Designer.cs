
namespace Tyuiu.VolodinaAA.Sprint7.Project.V10
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelRight_VAA = new System.Windows.Forms.Panel();
            this.buttonNext_VAA = new System.Windows.Forms.Button();
            this.panelFill_VAA = new System.Windows.Forms.Panel();
            this.labelPhoneNumber_VAA = new System.Windows.Forms.Label();
            this.maskedTextBoxPhoneNumber_VAA = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPatronymic_VAA = new System.Windows.Forms.TextBox();
            this.labelPatronymic_VAA = new System.Windows.Forms.Label();
            this.labelName_VAA = new System.Windows.Forms.Label();
            this.textBoxName_VAA = new System.Windows.Forms.TextBox();
            this.labelSurname_VAA = new System.Windows.Forms.Label();
            this.textBoxSurname_VAA = new System.Windows.Forms.TextBox();
            this.panelTop_VAA = new System.Windows.Forms.Panel();
            this.textBoxExplanation_VAA = new System.Windows.Forms.TextBox();
            this.openFileDialogNext_VAA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogCSV_VAA = new System.Windows.Forms.SaveFileDialog();
            this.checkBoxCondition_VAA = new System.Windows.Forms.CheckBox();
            this.comboBoxTowns_VAA = new System.Windows.Forms.ComboBox();
            this.labelTowns_VAA = new System.Windows.Forms.Label();
            this.panelRight_VAA.SuspendLayout();
            this.panelFill_VAA.SuspendLayout();
            this.panelTop_VAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRight_VAA
            // 
            this.panelRight_VAA.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelRight_VAA.Controls.Add(this.buttonNext_VAA);
            this.panelRight_VAA.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_VAA.Location = new System.Drawing.Point(933, 0);
            this.panelRight_VAA.Name = "panelRight_VAA";
            this.panelRight_VAA.Size = new System.Drawing.Size(200, 549);
            this.panelRight_VAA.TabIndex = 0;
            // 
            // buttonNext_VAA
            // 
            this.buttonNext_VAA.Enabled = false;
            this.buttonNext_VAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNext_VAA.Location = new System.Drawing.Point(15, 477);
            this.buttonNext_VAA.Name = "buttonNext_VAA";
            this.buttonNext_VAA.Size = new System.Drawing.Size(171, 53);
            this.buttonNext_VAA.TabIndex = 0;
            this.buttonNext_VAA.Text = "Продолжить";
            this.buttonNext_VAA.UseVisualStyleBackColor = true;
            this.buttonNext_VAA.Click += new System.EventHandler(this.buttonNext_VAA_Click);
            // 
            // panelFill_VAA
            // 
            this.panelFill_VAA.BackColor = System.Drawing.SystemColors.Window;
            this.panelFill_VAA.Controls.Add(this.labelTowns_VAA);
            this.panelFill_VAA.Controls.Add(this.comboBoxTowns_VAA);
            this.panelFill_VAA.Controls.Add(this.checkBoxCondition_VAA);
            this.panelFill_VAA.Controls.Add(this.labelPhoneNumber_VAA);
            this.panelFill_VAA.Controls.Add(this.maskedTextBoxPhoneNumber_VAA);
            this.panelFill_VAA.Controls.Add(this.textBoxPatronymic_VAA);
            this.panelFill_VAA.Controls.Add(this.labelPatronymic_VAA);
            this.panelFill_VAA.Controls.Add(this.labelName_VAA);
            this.panelFill_VAA.Controls.Add(this.textBoxName_VAA);
            this.panelFill_VAA.Controls.Add(this.labelSurname_VAA);
            this.panelFill_VAA.Controls.Add(this.textBoxSurname_VAA);
            this.panelFill_VAA.Controls.Add(this.panelTop_VAA);
            this.panelFill_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_VAA.Location = new System.Drawing.Point(0, 0);
            this.panelFill_VAA.Name = "panelFill_VAA";
            this.panelFill_VAA.Size = new System.Drawing.Size(933, 549);
            this.panelFill_VAA.TabIndex = 1;
            // 
            // labelPhoneNumber_VAA
            // 
            this.labelPhoneNumber_VAA.AutoSize = true;
            this.labelPhoneNumber_VAA.Font = new System.Drawing.Font("TT Travels Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneNumber_VAA.Location = new System.Drawing.Point(62, 335);
            this.labelPhoneNumber_VAA.Name = "labelPhoneNumber_VAA";
            this.labelPhoneNumber_VAA.Size = new System.Drawing.Size(185, 48);
            this.labelPhoneNumber_VAA.TabIndex = 8;
            this.labelPhoneNumber_VAA.Text = "Введите ваш \r\nномер телефона:";
            // 
            // maskedTextBoxPhoneNumber_VAA
            // 
            this.maskedTextBoxPhoneNumber_VAA.Font = new System.Drawing.Font("TT Travels Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPhoneNumber_VAA.Location = new System.Drawing.Point(66, 386);
            this.maskedTextBoxPhoneNumber_VAA.Mask = "+7(999) 000-0000";
            this.maskedTextBoxPhoneNumber_VAA.Name = "maskedTextBoxPhoneNumber_VAA";
            this.maskedTextBoxPhoneNumber_VAA.Size = new System.Drawing.Size(197, 31);
            this.maskedTextBoxPhoneNumber_VAA.TabIndex = 7;
            // 
            // textBoxPatronymic_VAA
            // 
            this.textBoxPatronymic_VAA.Location = new System.Drawing.Point(66, 291);
            this.textBoxPatronymic_VAA.Name = "textBoxPatronymic_VAA";
            this.textBoxPatronymic_VAA.Size = new System.Drawing.Size(412, 22);
            this.textBoxPatronymic_VAA.TabIndex = 6;
            // 
            // labelPatronymic_VAA
            // 
            this.labelPatronymic_VAA.AutoSize = true;
            this.labelPatronymic_VAA.Font = new System.Drawing.Font("TT Travels Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic_VAA.Location = new System.Drawing.Point(66, 264);
            this.labelPatronymic_VAA.Name = "labelPatronymic_VAA";
            this.labelPatronymic_VAA.Size = new System.Drawing.Size(412, 24);
            this.labelPatronymic_VAA.TabIndex = 5;
            this.labelPatronymic_VAA.Text = "Введите ваше отчество (при наличии):\r\n";
            // 
            // labelName_VAA
            // 
            this.labelName_VAA.AutoSize = true;
            this.labelName_VAA.Font = new System.Drawing.Font("TT Travels Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName_VAA.Location = new System.Drawing.Point(66, 195);
            this.labelName_VAA.Name = "labelName_VAA";
            this.labelName_VAA.Size = new System.Drawing.Size(284, 24);
            this.labelName_VAA.TabIndex = 4;
            this.labelName_VAA.Text = "Введите ваше полное имя:\r\n";
            // 
            // textBoxName_VAA
            // 
            this.textBoxName_VAA.Location = new System.Drawing.Point(66, 222);
            this.textBoxName_VAA.Name = "textBoxName_VAA";
            this.textBoxName_VAA.Size = new System.Drawing.Size(412, 22);
            this.textBoxName_VAA.TabIndex = 3;
            // 
            // labelSurname_VAA
            // 
            this.labelSurname_VAA.AutoSize = true;
            this.labelSurname_VAA.Font = new System.Drawing.Font("TT Travels Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname_VAA.Location = new System.Drawing.Point(62, 122);
            this.labelSurname_VAA.Name = "labelSurname_VAA";
            this.labelSurname_VAA.Size = new System.Drawing.Size(258, 24);
            this.labelSurname_VAA.TabIndex = 2;
            this.labelSurname_VAA.Text = "Введите вашу фамилию:";
            // 
            // textBoxSurname_VAA
            // 
            this.textBoxSurname_VAA.Location = new System.Drawing.Point(66, 149);
            this.textBoxSurname_VAA.Name = "textBoxSurname_VAA";
            this.textBoxSurname_VAA.Size = new System.Drawing.Size(412, 22);
            this.textBoxSurname_VAA.TabIndex = 1;
            // 
            // panelTop_VAA
            // 
            this.panelTop_VAA.Controls.Add(this.textBoxExplanation_VAA);
            this.panelTop_VAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_VAA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_VAA.Name = "panelTop_VAA";
            this.panelTop_VAA.Size = new System.Drawing.Size(933, 100);
            this.panelTop_VAA.TabIndex = 0;
            // 
            // textBoxExplanation_VAA
            // 
            this.textBoxExplanation_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExplanation_VAA.Font = new System.Drawing.Font("TT Travels Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExplanation_VAA.Location = new System.Drawing.Point(0, 0);
            this.textBoxExplanation_VAA.Multiline = true;
            this.textBoxExplanation_VAA.Name = "textBoxExplanation_VAA";
            this.textBoxExplanation_VAA.ReadOnly = true;
            this.textBoxExplanation_VAA.Size = new System.Drawing.Size(933, 100);
            this.textBoxExplanation_VAA.TabIndex = 0;
            this.textBoxExplanation_VAA.Text = "Для продолжения совершения заказа заполните следующие поля:";
            // 
            // openFileDialogNext_VAA
            // 
            this.openFileDialogNext_VAA.FileName = "openFileDialog1";
            // 
            // checkBoxCondition_VAA
            // 
            this.checkBoxCondition_VAA.AutoSize = true;
            this.checkBoxCondition_VAA.Location = new System.Drawing.Point(66, 453);
            this.checkBoxCondition_VAA.Name = "checkBoxCondition_VAA";
            this.checkBoxCondition_VAA.Size = new System.Drawing.Size(401, 21);
            this.checkBoxCondition_VAA.TabIndex = 9;
            this.checkBoxCondition_VAA.Text = "Вы согласны на обработку ваших персональных данных\r\n";
            this.checkBoxCondition_VAA.UseVisualStyleBackColor = true;
            this.checkBoxCondition_VAA.CheckedChanged += new System.EventHandler(this.checkBoxCondition_VAA_CheckedChanged);
            // 
            // comboBoxTowns_VAA
            // 
            this.comboBoxTowns_VAA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTowns_VAA.FormattingEnabled = true;
            this.comboBoxTowns_VAA.Items.AddRange(new object[] {
            "Тюмень",
            "Москва",
            "Санкт-Петербург",
            "Екатеринбург"});
            this.comboBoxTowns_VAA.Location = new System.Drawing.Point(612, 220);
            this.comboBoxTowns_VAA.Name = "comboBoxTowns_VAA";
            this.comboBoxTowns_VAA.Size = new System.Drawing.Size(190, 24);
            this.comboBoxTowns_VAA.TabIndex = 10;
            // 
            // labelTowns_VAA
            // 
            this.labelTowns_VAA.AutoSize = true;
            this.labelTowns_VAA.Font = new System.Drawing.Font("TT Travels Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTowns_VAA.Location = new System.Drawing.Point(608, 169);
            this.labelTowns_VAA.Name = "labelTowns_VAA";
            this.labelTowns_VAA.Size = new System.Drawing.Size(248, 48);
            this.labelTowns_VAA.TabIndex = 11;
            this.labelTowns_VAA.Text = "Выберите населённый\r\nпункт:";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 549);
            this.Controls.Add(this.panelFill_VAA);
            this.Controls.Add(this.panelRight_VAA);
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ОКНО РЕГИСТРАЦИИ";
            this.panelRight_VAA.ResumeLayout(false);
            this.panelFill_VAA.ResumeLayout(false);
            this.panelFill_VAA.PerformLayout();
            this.panelTop_VAA.ResumeLayout(false);
            this.panelTop_VAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRight_VAA;
        private System.Windows.Forms.Button buttonNext_VAA;
        private System.Windows.Forms.Panel panelFill_VAA;
        private System.Windows.Forms.Panel panelTop_VAA;
        private System.Windows.Forms.TextBox textBoxExplanation_VAA;
        private System.Windows.Forms.Label labelSurname_VAA;
        private System.Windows.Forms.TextBox textBoxSurname_VAA;
        private System.Windows.Forms.TextBox textBoxPatronymic_VAA;
        private System.Windows.Forms.Label labelPatronymic_VAA;
        private System.Windows.Forms.Label labelName_VAA;
        private System.Windows.Forms.TextBox textBoxName_VAA;
        private System.Windows.Forms.Label labelPhoneNumber_VAA;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber_VAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogNext_VAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCSV_VAA;
        private System.Windows.Forms.CheckBox checkBoxCondition_VAA;
        private System.Windows.Forms.Label labelTowns_VAA;
        private System.Windows.Forms.ComboBox comboBoxTowns_VAA;
    }
}