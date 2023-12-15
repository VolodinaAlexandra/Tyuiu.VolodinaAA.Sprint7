﻿
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_VAA = new System.Windows.Forms.Panel();
            this.panelLeft_VAA = new System.Windows.Forms.Panel();
            this.panelRight_VAA = new System.Windows.Forms.Panel();
            this.dataGridViewStatistic_VAA = new System.Windows.Forms.DataGridView();
            this.chartStatistic_VAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTask_VAA = new System.Windows.Forms.Label();
            this.buttonPopularThings_VAA = new System.Windows.Forms.Button();
            this.buttonPopularTowns_VAA = new System.Windows.Forms.Button();
            this.buttonUsers_VAA = new System.Windows.Forms.Button();
            this.radioButtonTablitsa_VAA = new System.Windows.Forms.RadioButton();
            this.radioButtonDiagram_VAA = new System.Windows.Forms.RadioButton();
            this.panelTop_VAA.SuspendLayout();
            this.panelLeft_VAA.SuspendLayout();
            this.panelRight_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic_VAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic_VAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_VAA
            // 
            this.panelTop_VAA.Controls.Add(this.radioButtonDiagram_VAA);
            this.panelTop_VAA.Controls.Add(this.radioButtonTablitsa_VAA);
            this.panelTop_VAA.Controls.Add(this.buttonUsers_VAA);
            this.panelTop_VAA.Controls.Add(this.buttonPopularTowns_VAA);
            this.panelTop_VAA.Controls.Add(this.buttonPopularThings_VAA);
            this.panelTop_VAA.Controls.Add(this.labelTask_VAA);
            this.panelTop_VAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_VAA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_VAA.Name = "panelTop_VAA";
            this.panelTop_VAA.Size = new System.Drawing.Size(1133, 100);
            this.panelTop_VAA.TabIndex = 0;
            // 
            // panelLeft_VAA
            // 
            this.panelLeft_VAA.Controls.Add(this.dataGridViewStatistic_VAA);
            this.panelLeft_VAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_VAA.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_VAA.Name = "panelLeft_VAA";
            this.panelLeft_VAA.Size = new System.Drawing.Size(554, 449);
            this.panelLeft_VAA.TabIndex = 1;
            // 
            // panelRight_VAA
            // 
            this.panelRight_VAA.Controls.Add(this.chartStatistic_VAA);
            this.panelRight_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_VAA.Location = new System.Drawing.Point(554, 100);
            this.panelRight_VAA.Name = "panelRight_VAA";
            this.panelRight_VAA.Size = new System.Drawing.Size(579, 449);
            this.panelRight_VAA.TabIndex = 2;
            // 
            // dataGridViewStatistic_VAA
            // 
            this.dataGridViewStatistic_VAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistic_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStatistic_VAA.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStatistic_VAA.Name = "dataGridViewStatistic_VAA";
            this.dataGridViewStatistic_VAA.RowHeadersWidth = 51;
            this.dataGridViewStatistic_VAA.RowTemplate.Height = 24;
            this.dataGridViewStatistic_VAA.Size = new System.Drawing.Size(554, 449);
            this.dataGridViewStatistic_VAA.TabIndex = 0;
            // 
            // chartStatistic_VAA
            // 
            chartArea3.Name = "ChartArea1";
            this.chartStatistic_VAA.ChartAreas.Add(chartArea3);
            this.chartStatistic_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartStatistic_VAA.Legends.Add(legend3);
            this.chartStatistic_VAA.Location = new System.Drawing.Point(0, 0);
            this.chartStatistic_VAA.Name = "chartStatistic_VAA";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartStatistic_VAA.Series.Add(series3);
            this.chartStatistic_VAA.Size = new System.Drawing.Size(579, 449);
            this.chartStatistic_VAA.TabIndex = 0;
            this.chartStatistic_VAA.Text = "chart1";
            // 
            // labelTask_VAA
            // 
            this.labelTask_VAA.AutoSize = true;
            this.labelTask_VAA.Font = new System.Drawing.Font("TT Travels DemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask_VAA.Location = new System.Drawing.Point(12, 0);
            this.labelTask_VAA.Name = "labelTask_VAA";
            this.labelTask_VAA.Size = new System.Drawing.Size(1126, 33);
            this.labelTask_VAA.TabIndex = 0;
            this.labelTask_VAA.Text = "Здесь вы можете посмотреть статистику разных сфер нашего приложения\r\n";
            // 
            // buttonPopularThings_VAA
            // 
            this.buttonPopularThings_VAA.Font = new System.Drawing.Font("TT Travels Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPopularThings_VAA.Location = new System.Drawing.Point(29, 46);
            this.buttonPopularThings_VAA.Name = "buttonPopularThings_VAA";
            this.buttonPopularThings_VAA.Size = new System.Drawing.Size(76, 31);
            this.buttonPopularThings_VAA.TabIndex = 1;
            this.buttonPopularThings_VAA.Text = "товары\r\n";
            this.buttonPopularThings_VAA.UseVisualStyleBackColor = true;
            // 
            // buttonPopularTowns_VAA
            // 
            this.buttonPopularTowns_VAA.Font = new System.Drawing.Font("TT Travels Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPopularTowns_VAA.Location = new System.Drawing.Point(111, 46);
            this.buttonPopularTowns_VAA.Name = "buttonPopularTowns_VAA";
            this.buttonPopularTowns_VAA.Size = new System.Drawing.Size(78, 31);
            this.buttonPopularTowns_VAA.TabIndex = 2;
            this.buttonPopularTowns_VAA.Text = "города\r\n";
            this.buttonPopularTowns_VAA.UseVisualStyleBackColor = true;
            // 
            // buttonUsers_VAA
            // 
            this.buttonUsers_VAA.Font = new System.Drawing.Font("TT Travels Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUsers_VAA.Location = new System.Drawing.Point(195, 46);
            this.buttonUsers_VAA.Name = "buttonUsers_VAA";
            this.buttonUsers_VAA.Size = new System.Drawing.Size(132, 31);
            this.buttonUsers_VAA.TabIndex = 3;
            this.buttonUsers_VAA.Text = "пользователи";
            this.buttonUsers_VAA.UseVisualStyleBackColor = true;
            // 
            // radioButtonTablitsa_VAA
            // 
            this.radioButtonTablitsa_VAA.AutoSize = true;
            this.radioButtonTablitsa_VAA.Font = new System.Drawing.Font("TT Travels Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonTablitsa_VAA.Location = new System.Drawing.Point(583, 56);
            this.radioButtonTablitsa_VAA.Name = "radioButtonTablitsa_VAA";
            this.radioButtonTablitsa_VAA.Size = new System.Drawing.Size(225, 21);
            this.radioButtonTablitsa_VAA.TabIndex = 4;
            this.radioButtonTablitsa_VAA.TabStop = true;
            this.radioButtonTablitsa_VAA.Text = "отобразить в виде таблицы";
            this.radioButtonTablitsa_VAA.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiagram_VAA
            // 
            this.radioButtonDiagram_VAA.AutoSize = true;
            this.radioButtonDiagram_VAA.Font = new System.Drawing.Font("TT Travels Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDiagram_VAA.Location = new System.Drawing.Point(854, 56);
            this.radioButtonDiagram_VAA.Name = "radioButtonDiagram_VAA";
            this.radioButtonDiagram_VAA.Size = new System.Drawing.Size(245, 21);
            this.radioButtonDiagram_VAA.TabIndex = 5;
            this.radioButtonDiagram_VAA.TabStop = true;
            this.radioButtonDiagram_VAA.Text = "отобразить в виде диаграммы";
            this.radioButtonDiagram_VAA.UseVisualStyleBackColor = true;
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 549);
            this.Controls.Add(this.panelRight_VAA);
            this.Controls.Add(this.panelLeft_VAA);
            this.Controls.Add(this.panelTop_VAA);
            this.Name = "FormStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СТАТИСТИКА ПРИЛОЖЕНИЯ";
            this.panelTop_VAA.ResumeLayout(false);
            this.panelTop_VAA.PerformLayout();
            this.panelLeft_VAA.ResumeLayout(false);
            this.panelRight_VAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic_VAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic_VAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_VAA;
        private System.Windows.Forms.Panel panelLeft_VAA;
        private System.Windows.Forms.DataGridView dataGridViewStatistic_VAA;
        private System.Windows.Forms.Panel panelRight_VAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistic_VAA;
        private System.Windows.Forms.RadioButton radioButtonDiagram_VAA;
        private System.Windows.Forms.RadioButton radioButtonTablitsa_VAA;
        private System.Windows.Forms.Button buttonUsers_VAA;
        private System.Windows.Forms.Button buttonPopularTowns_VAA;
        private System.Windows.Forms.Button buttonPopularThings_VAA;
        private System.Windows.Forms.Label labelTask_VAA;
    }
}