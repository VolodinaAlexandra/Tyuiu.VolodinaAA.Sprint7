
namespace Tyuiu.VolodinaAA.Sprint7.Project.V10
{
    partial class FormPersonalCabinet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonalCabinet));
            this.panelFill_VAA = new System.Windows.Forms.Panel();
            this.buttonEndofOrder_VAA = new System.Windows.Forms.Button();
            this.buttonItogo_VAA = new System.Windows.Forms.Button();
            this.labelItogo_VAA = new System.Windows.Forms.Label();
            this.textBoxItogo_VAA = new System.Windows.Forms.TextBox();
            this.checkedListBoxItems_VAA = new System.Windows.Forms.CheckedListBox();
            this.labelCapture_VAA = new System.Windows.Forms.Label();
            this.labelPrice_VAA = new System.Windows.Forms.Label();
            this.buttonNext_VAA = new System.Windows.Forms.Button();
            this.buttonPrevious_VAA = new System.Windows.Forms.Button();
            this.pictureBoxImages_VAA = new System.Windows.Forms.PictureBox();
            this.labelDate_VAA = new System.Windows.Forms.Label();
            this.dateTimePickerOrderEnd_VAA = new System.Windows.Forms.DateTimePicker();
            this.toolTipHelper = new System.Windows.Forms.ToolTip(this.components);
            this.panelFill_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImages_VAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFill_VAA
            // 
            this.panelFill_VAA.BackColor = System.Drawing.SystemColors.Control;
            this.panelFill_VAA.Controls.Add(this.buttonEndofOrder_VAA);
            this.panelFill_VAA.Controls.Add(this.buttonItogo_VAA);
            this.panelFill_VAA.Controls.Add(this.labelItogo_VAA);
            this.panelFill_VAA.Controls.Add(this.textBoxItogo_VAA);
            this.panelFill_VAA.Controls.Add(this.checkedListBoxItems_VAA);
            this.panelFill_VAA.Controls.Add(this.labelCapture_VAA);
            this.panelFill_VAA.Controls.Add(this.labelPrice_VAA);
            this.panelFill_VAA.Controls.Add(this.buttonNext_VAA);
            this.panelFill_VAA.Controls.Add(this.buttonPrevious_VAA);
            this.panelFill_VAA.Controls.Add(this.pictureBoxImages_VAA);
            this.panelFill_VAA.Controls.Add(this.labelDate_VAA);
            this.panelFill_VAA.Controls.Add(this.dateTimePickerOrderEnd_VAA);
            this.panelFill_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_VAA.Location = new System.Drawing.Point(0, 0);
            this.panelFill_VAA.Name = "panelFill_VAA";
            this.panelFill_VAA.Size = new System.Drawing.Size(808, 549);
            this.panelFill_VAA.TabIndex = 1;
            // 
            // buttonEndofOrder_VAA
            // 
            this.buttonEndofOrder_VAA.BackColor = System.Drawing.Color.White;
            this.buttonEndofOrder_VAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEndofOrder_VAA.Font = new System.Drawing.Font("TT Travels Regular", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEndofOrder_VAA.Location = new System.Drawing.Point(452, 405);
            this.buttonEndofOrder_VAA.Name = "buttonEndofOrder_VAA";
            this.buttonEndofOrder_VAA.Size = new System.Drawing.Size(226, 36);
            this.buttonEndofOrder_VAA.TabIndex = 12;
            this.buttonEndofOrder_VAA.Text = "Заказать";
            this.toolTipHelper.SetToolTip(this.buttonEndofOrder_VAA, "Нажмите, чтобы заказать выбранные позиции и перейти в меню заказа");
            this.buttonEndofOrder_VAA.UseVisualStyleBackColor = false;
            this.buttonEndofOrder_VAA.Click += new System.EventHandler(this.buttonEndofOrder_VAA_Click);
            this.buttonEndofOrder_VAA.MouseEnter += new System.EventHandler(this.buttonEndofOrder_VAA_MouseEnter);
            this.buttonEndofOrder_VAA.MouseLeave += new System.EventHandler(this.buttonEndofOrder_VAA_MouseLeave);
            // 
            // buttonItogo_VAA
            // 
            this.buttonItogo_VAA.BackColor = System.Drawing.Color.White;
            this.buttonItogo_VAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItogo_VAA.Font = new System.Drawing.Font("TT Travels Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonItogo_VAA.Location = new System.Drawing.Point(572, 356);
            this.buttonItogo_VAA.Name = "buttonItogo_VAA";
            this.buttonItogo_VAA.Size = new System.Drawing.Size(106, 24);
            this.buttonItogo_VAA.TabIndex = 11;
            this.buttonItogo_VAA.Text = "Рассчитать";
            this.toolTipHelper.SetToolTip(this.buttonItogo_VAA, "Нажмите, чтобы рассчитать итоговую сумму заказа");
            this.buttonItogo_VAA.UseVisualStyleBackColor = false;
            this.buttonItogo_VAA.Click += new System.EventHandler(this.buttonItogo_VAA_Click);
            this.buttonItogo_VAA.MouseEnter += new System.EventHandler(this.buttonItogo_VAA_MouseEnter);
            this.buttonItogo_VAA.MouseLeave += new System.EventHandler(this.buttonItogo_VAA_MouseLeave);
            // 
            // labelItogo_VAA
            // 
            this.labelItogo_VAA.AutoSize = true;
            this.labelItogo_VAA.BackColor = System.Drawing.Color.White;
            this.labelItogo_VAA.Font = new System.Drawing.Font("TT Travels Regular", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItogo_VAA.Location = new System.Drawing.Point(452, 332);
            this.labelItogo_VAA.Name = "labelItogo_VAA";
            this.labelItogo_VAA.Size = new System.Drawing.Size(217, 20);
            this.labelItogo_VAA.TabIndex = 10;
            this.labelItogo_VAA.Text = "Итоговая сумма заказа:";
            // 
            // textBoxItogo_VAA
            // 
            this.textBoxItogo_VAA.BackColor = System.Drawing.Color.White;
            this.textBoxItogo_VAA.Location = new System.Drawing.Point(452, 358);
            this.textBoxItogo_VAA.Name = "textBoxItogo_VAA";
            this.textBoxItogo_VAA.ReadOnly = true;
            this.textBoxItogo_VAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxItogo_VAA.TabIndex = 9;
            // 
            // checkedListBoxItems_VAA
            // 
            this.checkedListBoxItems_VAA.Font = new System.Drawing.Font("TT Travels Regular", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxItems_VAA.FormattingEnabled = true;
            this.checkedListBoxItems_VAA.Items.AddRange(new object[] {
            "Ёлочная игрушка Ангелочки",
            "Набор ёлочных игрушек",
            "Ёлочная игрушка Полумесяц",
            "Ёлочная игрушка Бантик",
            "Ёлочная игрушка Щелкунчик",
            "Ёлочная игрушка Избушка",
            "Ёлочная игрушка Матрёшка"});
            this.checkedListBoxItems_VAA.Location = new System.Drawing.Point(448, 144);
            this.checkedListBoxItems_VAA.Name = "checkedListBoxItems_VAA";
            this.checkedListBoxItems_VAA.Size = new System.Drawing.Size(357, 124);
            this.checkedListBoxItems_VAA.TabIndex = 8;
            this.toolTipHelper.SetToolTip(this.checkedListBoxItems_VAA, "Выберите понравившиеся игрушки и поставьте галочку двойным щелчком по квадрату");
            // 
            // labelCapture_VAA
            // 
            this.labelCapture_VAA.AutoSize = true;
            this.labelCapture_VAA.BackColor = System.Drawing.Color.White;
            this.labelCapture_VAA.Font = new System.Drawing.Font("TT Travels Regular", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCapture_VAA.Location = new System.Drawing.Point(445, 86);
            this.labelCapture_VAA.Name = "labelCapture_VAA";
            this.labelCapture_VAA.Size = new System.Drawing.Size(81, 20);
            this.labelCapture_VAA.TabIndex = 7;
            this.labelCapture_VAA.Text = "Capture";
            // 
            // labelPrice_VAA
            // 
            this.labelPrice_VAA.AutoSize = true;
            this.labelPrice_VAA.BackColor = System.Drawing.Color.White;
            this.labelPrice_VAA.Font = new System.Drawing.Font("TT Travels Regular", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice_VAA.Location = new System.Drawing.Point(445, 55);
            this.labelPrice_VAA.Name = "labelPrice_VAA";
            this.labelPrice_VAA.Size = new System.Drawing.Size(54, 20);
            this.labelPrice_VAA.TabIndex = 6;
            this.labelPrice_VAA.Text = "Price";
            // 
            // buttonNext_VAA
            // 
            this.buttonNext_VAA.BackColor = System.Drawing.Color.White;
            this.buttonNext_VAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext_VAA.Font = new System.Drawing.Font("TT Travels ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext_VAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonNext_VAA.Image")));
            this.buttonNext_VAA.Location = new System.Drawing.Point(256, 478);
            this.buttonNext_VAA.Name = "buttonNext_VAA";
            this.buttonNext_VAA.Size = new System.Drawing.Size(157, 47);
            this.buttonNext_VAA.TabIndex = 5;
            this.buttonNext_VAA.UseVisualStyleBackColor = false;
            this.buttonNext_VAA.Click += new System.EventHandler(this.buttonNext_VAA_Click);
            this.buttonNext_VAA.MouseEnter += new System.EventHandler(this.buttonNext_VAA_MouseEnter);
            this.buttonNext_VAA.MouseLeave += new System.EventHandler(this.buttonNext_VAA_MouseLeave);
            // 
            // buttonPrevious_VAA
            // 
            this.buttonPrevious_VAA.BackColor = System.Drawing.Color.White;
            this.buttonPrevious_VAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious_VAA.Font = new System.Drawing.Font("TT Travels ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrevious_VAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrevious_VAA.Image")));
            this.buttonPrevious_VAA.Location = new System.Drawing.Point(103, 478);
            this.buttonPrevious_VAA.Name = "buttonPrevious_VAA";
            this.buttonPrevious_VAA.Size = new System.Drawing.Size(156, 47);
            this.buttonPrevious_VAA.TabIndex = 4;
            this.buttonPrevious_VAA.UseVisualStyleBackColor = false;
            this.buttonPrevious_VAA.Click += new System.EventHandler(this.buttonPrevious_VAA_Click);
            this.buttonPrevious_VAA.MouseEnter += new System.EventHandler(this.buttonPrevious_VAA_MouseEnter);
            this.buttonPrevious_VAA.MouseLeave += new System.EventHandler(this.buttonPrevious_VAA_MouseLeave);
            // 
            // pictureBoxImages_VAA
            // 
            this.pictureBoxImages_VAA.BackColor = System.Drawing.Color.White;
            this.pictureBoxImages_VAA.Location = new System.Drawing.Point(103, 55);
            this.pictureBoxImages_VAA.Name = "pictureBoxImages_VAA";
            this.pictureBoxImages_VAA.Size = new System.Drawing.Size(310, 413);
            this.pictureBoxImages_VAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImages_VAA.TabIndex = 2;
            this.pictureBoxImages_VAA.TabStop = false;
            // 
            // labelDate_VAA
            // 
            this.labelDate_VAA.AutoSize = true;
            this.labelDate_VAA.BackColor = System.Drawing.Color.White;
            this.labelDate_VAA.Font = new System.Drawing.Font("TT Travels Regular", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate_VAA.Location = new System.Drawing.Point(447, 280);
            this.labelDate_VAA.Name = "labelDate_VAA";
            this.labelDate_VAA.Size = new System.Drawing.Size(342, 20);
            this.labelDate_VAA.TabIndex = 1;
            this.labelDate_VAA.Text = "Выберите желаемую дату исполнения";
            // 
            // dateTimePickerOrderEnd_VAA
            // 
            this.dateTimePickerOrderEnd_VAA.Location = new System.Drawing.Point(451, 303);
            this.dateTimePickerOrderEnd_VAA.Name = "dateTimePickerOrderEnd_VAA";
            this.dateTimePickerOrderEnd_VAA.Size = new System.Drawing.Size(328, 22);
            this.dateTimePickerOrderEnd_VAA.TabIndex = 0;
            this.toolTipHelper.SetToolTip(this.dateTimePickerOrderEnd_VAA, "Нажмите на стрелку вниз, чтобы выбрать желаемую дату исполнения");
            // 
            // toolTipHelper
            // 
            this.toolTipHelper.IsBalloon = true;
            this.toolTipHelper.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHelper.ToolTipTitle = "Подсказка";
            // 
            // FormPersonalCabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 549);
            this.Controls.Add(this.panelFill_VAA);
            this.Name = "FormPersonalCabinet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "МЕНЮ ЗАКАЗА";
            this.Load += new System.EventHandler(this.FormPersonalCabinet_Load);
            this.panelFill_VAA.ResumeLayout(false);
            this.panelFill_VAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImages_VAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFill_VAA;
        private System.Windows.Forms.Label labelDate_VAA;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderEnd_VAA;
        private System.Windows.Forms.PictureBox pictureBoxImages_VAA;
        private System.Windows.Forms.Button buttonNext_VAA;
        private System.Windows.Forms.Button buttonPrevious_VAA;
        private System.Windows.Forms.Label labelCapture_VAA;
        private System.Windows.Forms.Label labelPrice_VAA;
        private System.Windows.Forms.CheckedListBox checkedListBoxItems_VAA;
        private System.Windows.Forms.Label labelItogo_VAA;
        private System.Windows.Forms.TextBox textBoxItogo_VAA;
        private System.Windows.Forms.Button buttonItogo_VAA;
        private System.Windows.Forms.Button buttonEndofOrder_VAA;
        private System.Windows.Forms.ToolTip toolTipHelper;
    }
}