﻿
namespace Tyuiu.VolodinaAA.Sprint7.Project.V10
{
    partial class FormMain
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
            this.buttonGoToOrder_VAA = new System.Windows.Forms.Button();
            this.panelRight_VAA = new System.Windows.Forms.Panel();
            this.panelRight_VAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGoToOrder_VAA
            // 
            this.buttonGoToOrder_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGoToOrder_VAA.BackColor = System.Drawing.SystemColors.Control;
            this.buttonGoToOrder_VAA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGoToOrder_VAA.Location = new System.Drawing.Point(17, 475);
            this.buttonGoToOrder_VAA.Name = "buttonGoToOrder_VAA";
            this.buttonGoToOrder_VAA.Size = new System.Drawing.Size(171, 53);
            this.buttonGoToOrder_VAA.TabIndex = 0;
            this.buttonGoToOrder_VAA.Text = "Перейти к оформлению заказа";
            this.buttonGoToOrder_VAA.UseVisualStyleBackColor = false;
            this.buttonGoToOrder_VAA.Click += new System.EventHandler(this.buttonGoToOrder_VAA_Click);
            this.buttonGoToOrder_VAA.MouseEnter += new System.EventHandler(this.buttonGoToOrder_VAA_MouseEnter);
            this.buttonGoToOrder_VAA.MouseLeave += new System.EventHandler(this.buttonGoToOrder_VAA_MouseLeave);
            // 
            // panelRight_VAA
            // 
            this.panelRight_VAA.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelRight_VAA.Controls.Add(this.buttonGoToOrder_VAA);
            this.panelRight_VAA.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_VAA.Location = new System.Drawing.Point(933, 0);
            this.panelRight_VAA.Name = "panelRight_VAA";
            this.panelRight_VAA.Size = new System.Drawing.Size(200, 549);
            this.panelRight_VAA.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 549);
            this.Controls.Add(this.panelRight_VAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЗАКАЗЫ";
            this.panelRight_VAA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGoToOrder_VAA;
        private System.Windows.Forms.Panel panelRight_VAA;
    }
}

