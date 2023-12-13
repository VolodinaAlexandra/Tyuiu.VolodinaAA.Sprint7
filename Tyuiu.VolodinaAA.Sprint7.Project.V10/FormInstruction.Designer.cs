
namespace Tyuiu.VolodinaAA.Sprint7.Project.V10
{
    partial class FormInstruction
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
            this.labelUserManual_VAA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUserManual_VAA
            // 
            this.labelUserManual_VAA.AutoSize = true;
            this.labelUserManual_VAA.Location = new System.Drawing.Point(12, 9);
            this.labelUserManual_VAA.Name = "labelUserManual_VAA";
            this.labelUserManual_VAA.Size = new System.Drawing.Size(518, 68);
            this.labelUserManual_VAA.TabIndex = 0;
            this.labelUserManual_VAA.Text = "Здравствуйте! Вас приветствует разработчик данного приложения.\r\n\r\nПриложение пред" +
    "назначено для того, чтобы клиенты сервиса могли узнать \r\nнаименование заказа, ег" +
    "о номер, дату исполнения, ";
            // 
            // FormInstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.labelUserManual_VAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInstruction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "РУКОВОДСТВО К ПОЛЬЗОВАНИЮ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserManual_VAA;
    }
}