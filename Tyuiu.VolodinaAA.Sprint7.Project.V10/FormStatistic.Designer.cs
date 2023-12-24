
namespace Tyuiu.VolodinaAA.Sprint7.Project.V10
{
    partial class FormStatistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_VAA = new System.Windows.Forms.Panel();
            this.buttonSales_VAA = new System.Windows.Forms.Button();
            this.buttonPopularThings_VAA = new System.Windows.Forms.Button();
            this.labelTask_VAA = new System.Windows.Forms.Label();
            this.panelRight_VAA = new System.Windows.Forms.Panel();
            this.chartStatistic_VAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_VAA.SuspendLayout();
            this.panelRight_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic_VAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_VAA
            // 
            this.panelTop_VAA.Controls.Add(this.buttonSales_VAA);
            this.panelTop_VAA.Controls.Add(this.buttonPopularThings_VAA);
            this.panelTop_VAA.Controls.Add(this.labelTask_VAA);
            this.panelTop_VAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_VAA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_VAA.Name = "panelTop_VAA";
            this.panelTop_VAA.Size = new System.Drawing.Size(1146, 100);
            this.panelTop_VAA.TabIndex = 0;
            // 
            // buttonSales_VAA
            // 
            this.buttonSales_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSales_VAA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSales_VAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSales_VAA.Font = new System.Drawing.Font("TT Travels Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSales_VAA.Location = new System.Drawing.Point(659, 63);
            this.buttonSales_VAA.Name = "buttonSales_VAA";
            this.buttonSales_VAA.Size = new System.Drawing.Size(222, 31);
            this.buttonSales_VAA.TabIndex = 3;
            this.buttonSales_VAA.Text = "Продажи";
            this.toolTip1.SetToolTip(this.buttonSales_VAA, "Нажмите, чтобы увидеть продажи за 2023 год");
            this.buttonSales_VAA.UseVisualStyleBackColor = false;
            this.buttonSales_VAA.Click += new System.EventHandler(this.buttonSales_VAA_Click);
            this.buttonSales_VAA.MouseEnter += new System.EventHandler(this.buttonSales_VAA_MouseEnter);
            this.buttonSales_VAA.MouseLeave += new System.EventHandler(this.buttonSales_VAA_MouseLeave);
            // 
            // buttonPopularThings_VAA
            // 
            this.buttonPopularThings_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPopularThings_VAA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPopularThings_VAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPopularThings_VAA.Font = new System.Drawing.Font("TT Travels Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPopularThings_VAA.Location = new System.Drawing.Point(901, 63);
            this.buttonPopularThings_VAA.Name = "buttonPopularThings_VAA";
            this.buttonPopularThings_VAA.Size = new System.Drawing.Size(222, 31);
            this.buttonPopularThings_VAA.TabIndex = 1;
            this.buttonPopularThings_VAA.Text = "Товары\r\n";
            this.toolTip1.SetToolTip(this.buttonPopularThings_VAA, "Нажмите, чтобы увидеть рейтинг проданных товаров за 2023 год");
            this.buttonPopularThings_VAA.UseVisualStyleBackColor = false;
            this.buttonPopularThings_VAA.Click += new System.EventHandler(this.buttonPopularThings_VAA_Click);
            this.buttonPopularThings_VAA.MouseEnter += new System.EventHandler(this.buttonPopularThings_VAA_MouseEnter);
            this.buttonPopularThings_VAA.MouseLeave += new System.EventHandler(this.buttonPopularThings_VAA_MouseLeave);
            // 
            // labelTask_VAA
            // 
            this.labelTask_VAA.AutoSize = true;
            this.labelTask_VAA.Font = new System.Drawing.Font("TT Travels DemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask_VAA.Location = new System.Drawing.Point(-6, 0);
            this.labelTask_VAA.Name = "labelTask_VAA";
            this.labelTask_VAA.Size = new System.Drawing.Size(1107, 66);
            this.labelTask_VAA.TabIndex = 0;
            this.labelTask_VAA.Text = "Здесь вы можете посмотреть данные за 2023 год о проданных единицах \r\nи об общем к" +
    "оличестве продаж\r\n";
            // 
            // panelRight_VAA
            // 
            this.panelRight_VAA.Controls.Add(this.chartStatistic_VAA);
            this.panelRight_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_VAA.Location = new System.Drawing.Point(0, 100);
            this.panelRight_VAA.Name = "panelRight_VAA";
            this.panelRight_VAA.Size = new System.Drawing.Size(1146, 535);
            this.panelRight_VAA.TabIndex = 2;
            // 
            // chartStatistic_VAA
            // 
            chartArea4.Name = "ChartArea1";
            this.chartStatistic_VAA.ChartAreas.Add(chartArea4);
            this.chartStatistic_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chartStatistic_VAA.Legends.Add(legend4);
            this.chartStatistic_VAA.Location = new System.Drawing.Point(0, 0);
            this.chartStatistic_VAA.Name = "chartStatistic_VAA";
            this.chartStatistic_VAA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "SeriesChartStatistic";
            this.chartStatistic_VAA.Series.Add(series4);
            this.chartStatistic_VAA.Size = new System.Drawing.Size(1146, 535);
            this.chartStatistic_VAA.TabIndex = 0;
            this.chartStatistic_VAA.Text = "chart1";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 635);
            this.Controls.Add(this.panelRight_VAA);
            this.Controls.Add(this.panelTop_VAA);
            this.Name = "FormStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ДАННЫЕ О ПРОДАЖАХ";
            this.panelTop_VAA.ResumeLayout(false);
            this.panelTop_VAA.PerformLayout();
            this.panelRight_VAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic_VAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_VAA;
        private System.Windows.Forms.Panel panelRight_VAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistic_VAA;
        private System.Windows.Forms.Button buttonSales_VAA;
        private System.Windows.Forms.Button buttonPopularThings_VAA;
        private System.Windows.Forms.Label labelTask_VAA;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}