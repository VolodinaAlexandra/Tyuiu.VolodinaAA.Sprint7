
namespace Tyuiu.VolodinaAA.Sprint7.Project.V10
{
    partial class FormAuthorise
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
            this.components = new System.ComponentModel.Container();
            this.textBoxLogin_VAA = new System.Windows.Forms.TextBox();
            this.textBoxPassword_VAA = new System.Windows.Forms.TextBox();
            this.labelLogin_VAA = new System.Windows.Forms.Label();
            this.labelPassword_VAA = new System.Windows.Forms.Label();
            this.labelInfo_VAA = new System.Windows.Forms.Label();
            this.buttonContinue_VAA = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBoxLogin_VAA
            // 
            this.textBoxLogin_VAA.Location = new System.Drawing.Point(36, 119);
            this.textBoxLogin_VAA.Name = "textBoxLogin_VAA";
            this.textBoxLogin_VAA.Size = new System.Drawing.Size(199, 23);
            this.textBoxLogin_VAA.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBoxLogin_VAA, "Введите логин не длиннее 16 символов,можно использовать буквы и цифры");
            this.textBoxLogin_VAA.TextChanged += new System.EventHandler(this.textBoxLogin_VAA_TextChanged);
            this.textBoxLogin_VAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_VAA_KeyPress);
            // 
            // textBoxPassword_VAA
            // 
            this.textBoxPassword_VAA.Location = new System.Drawing.Point(353, 119);
            this.textBoxPassword_VAA.Name = "textBoxPassword_VAA";
            this.textBoxPassword_VAA.Size = new System.Drawing.Size(196, 23);
            this.textBoxPassword_VAA.TabIndex = 1;
            this.textBoxPassword_VAA.TextChanged += new System.EventHandler(this.textBoxPassword_VAA_TextChanged);
            this.textBoxPassword_VAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_VAA_KeyPress);
            // 
            // labelLogin_VAA
            // 
            this.labelLogin_VAA.AutoSize = true;
            this.labelLogin_VAA.Font = new System.Drawing.Font("TT Travels Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin_VAA.Location = new System.Drawing.Point(33, 99);
            this.labelLogin_VAA.Name = "labelLogin_VAA";
            this.labelLogin_VAA.Size = new System.Drawing.Size(54, 17);
            this.labelLogin_VAA.TabIndex = 2;
            this.labelLogin_VAA.Text = "Логин";
            this.toolTip1.SetToolTip(this.labelLogin_VAA, "Введите логин не длиннее 16 символов,можно использовать буквы и цифры");
            // 
            // labelPassword_VAA
            // 
            this.labelPassword_VAA.AutoSize = true;
            this.labelPassword_VAA.Font = new System.Drawing.Font("TT Travels Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword_VAA.Location = new System.Drawing.Point(350, 99);
            this.labelPassword_VAA.Name = "labelPassword_VAA";
            this.labelPassword_VAA.Size = new System.Drawing.Size(65, 17);
            this.labelPassword_VAA.TabIndex = 3;
            this.labelPassword_VAA.Text = "Пароль";
            this.toolTip1.SetToolTip(this.labelPassword_VAA, "Введите пароль,длина которого должна быть равна 8\r\nМожно использовать буквы и циф" +
        "ры");
            // 
            // labelInfo_VAA
            // 
            this.labelInfo_VAA.AutoSize = true;
            this.labelInfo_VAA.Font = new System.Drawing.Font("TT Travels Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_VAA.Location = new System.Drawing.Point(-2, 9);
            this.labelInfo_VAA.Name = "labelInfo_VAA";
            this.labelInfo_VAA.Size = new System.Drawing.Size(613, 58);
            this.labelInfo_VAA.TabIndex = 4;
            this.labelInfo_VAA.Text = "Введите логин и пароль для регистрации или \r\nвхода в приложение\r\n";
            // 
            // buttonContinue_VAA
            // 
            this.buttonContinue_VAA.Enabled = false;
            this.buttonContinue_VAA.Location = new System.Drawing.Point(417, 166);
            this.buttonContinue_VAA.Name = "buttonContinue_VAA";
            this.buttonContinue_VAA.Size = new System.Drawing.Size(173, 38);
            this.buttonContinue_VAA.TabIndex = 6;
            this.buttonContinue_VAA.Text = "Сохранить данные";
            this.buttonContinue_VAA.UseVisualStyleBackColor = true;
            this.buttonContinue_VAA.Click += new System.EventHandler(this.buttonContinue_VAA_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // FormAuthorise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 216);
            this.Controls.Add(this.buttonContinue_VAA);
            this.Controls.Add(this.labelInfo_VAA);
            this.Controls.Add(this.labelPassword_VAA);
            this.Controls.Add(this.labelLogin_VAA);
            this.Controls.Add(this.textBoxPassword_VAA);
            this.Controls.Add(this.textBoxLogin_VAA);
            this.Font = new System.Drawing.Font("TT Travels Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAuthorise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АВТОРИЗАЦИЯ ПОЛЬЗОВАТЕЛЯ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin_VAA;
        private System.Windows.Forms.TextBox textBoxPassword_VAA;
        private System.Windows.Forms.Label labelLogin_VAA;
        private System.Windows.Forms.Label labelPassword_VAA;
        private System.Windows.Forms.Label labelInfo_VAA;
        private System.Windows.Forms.Button buttonContinue_VAA;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}