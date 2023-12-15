
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
            this.buttonInstruction_VAA = new System.Windows.Forms.Button();
            this.buttonInformation_VAA = new System.Windows.Forms.Button();
            this.buttonStatistic_VAA = new System.Windows.Forms.Button();
            this.panelRight_VAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGoToOrder_VAA
            // 
            this.buttonGoToOrder_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGoToOrder_VAA.BackColor = System.Drawing.SystemColors.Control;
            this.buttonGoToOrder_VAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGoToOrder_VAA.Font = new System.Drawing.Font("TT Travels Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoToOrder_VAA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGoToOrder_VAA.Location = new System.Drawing.Point(17, 437);
            this.buttonGoToOrder_VAA.Name = "buttonGoToOrder_VAA";
            this.buttonGoToOrder_VAA.Size = new System.Drawing.Size(171, 91);
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
            this.panelRight_VAA.Controls.Add(this.buttonStatistic_VAA);
            this.panelRight_VAA.Controls.Add(this.buttonInstruction_VAA);
            this.panelRight_VAA.Controls.Add(this.buttonInformation_VAA);
            this.panelRight_VAA.Controls.Add(this.buttonGoToOrder_VAA);
            this.panelRight_VAA.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_VAA.Location = new System.Drawing.Point(933, 0);
            this.panelRight_VAA.Name = "panelRight_VAA";
            this.panelRight_VAA.Size = new System.Drawing.Size(200, 549);
            this.panelRight_VAA.TabIndex = 1;
            // 
            // buttonInstruction_VAA
            // 
            this.buttonInstruction_VAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInstruction_VAA.Font = new System.Drawing.Font("TT Travels Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInstruction_VAA.Location = new System.Drawing.Point(17, 12);
            this.buttonInstruction_VAA.Name = "buttonInstruction_VAA";
            this.buttonInstruction_VAA.Size = new System.Drawing.Size(171, 42);
            this.buttonInstruction_VAA.TabIndex = 1;
            this.buttonInstruction_VAA.Text = "Руководство к пользованию";
            this.buttonInstruction_VAA.UseVisualStyleBackColor = true;
            this.buttonInstruction_VAA.Click += new System.EventHandler(this.buttonInstruction_VAA_Click);
            // 
            // buttonInformation_VAA
            // 
            this.buttonInformation_VAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInformation_VAA.Font = new System.Drawing.Font("TT Travels Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInformation_VAA.Location = new System.Drawing.Point(17, 60);
            this.buttonInformation_VAA.Name = "buttonInformation_VAA";
            this.buttonInformation_VAA.Size = new System.Drawing.Size(171, 38);
            this.buttonInformation_VAA.TabIndex = 1;
            this.buttonInformation_VAA.Text = "О программе";
            this.buttonInformation_VAA.UseVisualStyleBackColor = true;
            this.buttonInformation_VAA.Click += new System.EventHandler(this.buttonInformation_VAA_Click);
            // 
            // buttonStatistic_VAA
            // 
            this.buttonStatistic_VAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStatistic_VAA.Font = new System.Drawing.Font("TT Travels Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStatistic_VAA.Location = new System.Drawing.Point(17, 105);
            this.buttonStatistic_VAA.Name = "buttonStatistic_VAA";
            this.buttonStatistic_VAA.Size = new System.Drawing.Size(171, 60);
            this.buttonStatistic_VAA.TabIndex = 2;
            this.buttonStatistic_VAA.Text = "Просмотреть статистику приложения";
            this.buttonStatistic_VAA.UseVisualStyleBackColor = true;
            this.buttonStatistic_VAA.Click += new System.EventHandler(this.buttonStatistic_VAA_Click);
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
        private System.Windows.Forms.Button buttonInstruction_VAA;
        private System.Windows.Forms.Button buttonInformation_VAA;
        private System.Windows.Forms.Button buttonStatistic_VAA;
    }
}

