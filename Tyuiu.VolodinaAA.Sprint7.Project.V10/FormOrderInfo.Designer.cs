
namespace Tyuiu.VolodinaAA.Sprint7.Project.V10
{
    partial class FormOrderInfo
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
            this.textBoxOrderNumber_VAA = new System.Windows.Forms.TextBox();
            this.labelOrderNumber_VAA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxOrderNumber_VAA
            // 
            this.textBoxOrderNumber_VAA.Location = new System.Drawing.Point(40, 41);
            this.textBoxOrderNumber_VAA.Name = "textBoxOrderNumber_VAA";
            this.textBoxOrderNumber_VAA.Size = new System.Drawing.Size(255, 23);
            this.textBoxOrderNumber_VAA.TabIndex = 0;
            // 
            // labelOrderNumber_VAA
            // 
            this.labelOrderNumber_VAA.AutoSize = true;
            this.labelOrderNumber_VAA.Font = new System.Drawing.Font("TT Travels DemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderNumber_VAA.Location = new System.Drawing.Point(40, 13);
            this.labelOrderNumber_VAA.Name = "labelOrderNumber_VAA";
            this.labelOrderNumber_VAA.Size = new System.Drawing.Size(209, 20);
            this.labelOrderNumber_VAA.TabIndex = 1;
            this.labelOrderNumber_VAA.Text = "Номер вашего заказа:\r\n";
            // 
            // FormOrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 549);
            this.Controls.Add(this.labelOrderNumber_VAA);
            this.Controls.Add(this.textBoxOrderNumber_VAA);
            this.Font = new System.Drawing.Font("TT Travels Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormOrderInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИНФОРМАЦИЯ О ВАШЕМ ЗАКАЗЕ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOrderNumber_VAA;
        private System.Windows.Forms.Label labelOrderNumber_VAA;
    }
}