
namespace Tyuiu.VolodinaAA.Sprint7.Project.V10
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatarka_VAA = new System.Windows.Forms.PictureBox();
            this.labelInformation_VAA = new System.Windows.Forms.Label();
            this.buttonOK_VAA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatarka_VAA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatarka_VAA
            // 
            this.pictureBoxAvatarka_VAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatarka_VAA.Image")));
            this.pictureBoxAvatarka_VAA.Location = new System.Drawing.Point(29, 12);
            this.pictureBoxAvatarka_VAA.Name = "pictureBoxAvatarka_VAA";
            this.pictureBoxAvatarka_VAA.Size = new System.Drawing.Size(169, 228);
            this.pictureBoxAvatarka_VAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatarka_VAA.TabIndex = 0;
            this.pictureBoxAvatarka_VAA.TabStop = false;
            // 
            // labelInformation_VAA
            // 
            this.labelInformation_VAA.AutoSize = true;
            this.labelInformation_VAA.Font = new System.Drawing.Font("TT Travels Regular", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInformation_VAA.Location = new System.Drawing.Point(223, 12);
            this.labelInformation_VAA.Name = "labelInformation_VAA";
            this.labelInformation_VAA.Size = new System.Drawing.Size(482, 180);
            this.labelInformation_VAA.TabIndex = 1;
            this.labelInformation_VAA.Text = resources.GetString("labelInformation_VAA.Text");
            // 
            // buttonOK_VAA
            // 
            this.buttonOK_VAA.BackColor = System.Drawing.Color.White;
            this.buttonOK_VAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOK_VAA.Location = new System.Drawing.Point(421, 207);
            this.buttonOK_VAA.Name = "buttonOK_VAA";
            this.buttonOK_VAA.Size = new System.Drawing.Size(80, 33);
            this.buttonOK_VAA.TabIndex = 2;
            this.buttonOK_VAA.Text = "OK";
            this.buttonOK_VAA.UseVisualStyleBackColor = false;
            this.buttonOK_VAA.Click += new System.EventHandler(this.buttonOK_VAA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 254);
            this.Controls.Add(this.buttonOK_VAA);
            this.Controls.Add(this.labelInformation_VAA);
            this.Controls.Add(this.pictureBoxAvatarka_VAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИНФОРМАЦИЯ О РАЗРАБОТЧИКЕ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatarka_VAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatarka_VAA;
        private System.Windows.Forms.Label labelInformation_VAA;
        private System.Windows.Forms.Button buttonOK_VAA;
    }
}