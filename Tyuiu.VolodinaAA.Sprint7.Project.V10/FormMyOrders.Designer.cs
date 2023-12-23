
namespace Tyuiu.VolodinaAA.Sprint7.Project.V10
{
    partial class FormMyOrders
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
            this.labelListOfOrders_VAA = new System.Windows.Forms.Label();
            this.labelTask_VAA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelListOfOrders_VAA
            // 
            this.labelListOfOrders_VAA.AutoSize = true;
            this.labelListOfOrders_VAA.Font = new System.Drawing.Font("TT Travels Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListOfOrders_VAA.Location = new System.Drawing.Point(12, 53);
            this.labelListOfOrders_VAA.Name = "labelListOfOrders_VAA";
            this.labelListOfOrders_VAA.Size = new System.Drawing.Size(92, 33);
            this.labelListOfOrders_VAA.TabIndex = 0;
            this.labelListOfOrders_VAA.Text = "label1";
            // 
            // labelTask_VAA
            // 
            this.labelTask_VAA.AutoSize = true;
            this.labelTask_VAA.Font = new System.Drawing.Font("TT Travels Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask_VAA.Location = new System.Drawing.Point(12, 20);
            this.labelTask_VAA.Name = "labelTask_VAA";
            this.labelTask_VAA.Size = new System.Drawing.Size(461, 33);
            this.labelTask_VAA.TabIndex = 1;
            this.labelTask_VAA.Text = "Наименование вашего заказа:";
            // 
            // FormMyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 464);
            this.Controls.Add(this.labelTask_VAA);
            this.Controls.Add(this.labelListOfOrders_VAA);
            this.Name = "FormMyOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "МОИ ЗАКАЗЫ";
            this.Load += new System.EventHandler(this.FormMyOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListOfOrders_VAA;
        private System.Windows.Forms.Label labelTask_VAA;
    }
}