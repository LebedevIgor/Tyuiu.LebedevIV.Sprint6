
namespace Tyuiu.LebedevIV.Sprint6.Task5.V1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_LIV = new System.Windows.Forms.GroupBox();
            this.buttonDone_LIV = new System.Windows.Forms.Button();
            this.buttonHelp_LIV = new System.Windows.Forms.Button();
            this.buttonOpen_LIV = new System.Windows.Forms.Button();
            this.textBoxCondition_LIV = new System.Windows.Forms.TextBox();
            this.groupBoxResult_LIV = new System.Windows.Forms.GroupBox();
            this.chartResult_LIV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResult_LIV = new System.Windows.Forms.DataGridView();
            this.groupBoxCondition_LIV.SuspendLayout();
            this.groupBoxResult_LIV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_LIV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_LIV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_LIV
            // 
            this.groupBoxCondition_LIV.Controls.Add(this.textBoxCondition_LIV);
            this.groupBoxCondition_LIV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_LIV.Name = "groupBoxCondition_LIV";
            this.groupBoxCondition_LIV.Size = new System.Drawing.Size(510, 81);
            this.groupBoxCondition_LIV.TabIndex = 0;
            this.groupBoxCondition_LIV.TabStop = false;
            this.groupBoxCondition_LIV.Text = "Условие:";
            // 
            // buttonDone_LIV
            // 
            this.buttonDone_LIV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_LIV.Location = new System.Drawing.Point(538, 17);
            this.buttonDone_LIV.Name = "buttonDone_LIV";
            this.buttonDone_LIV.Size = new System.Drawing.Size(87, 76);
            this.buttonDone_LIV.TabIndex = 1;
            this.buttonDone_LIV.Text = "Выполнить";
            this.buttonDone_LIV.UseVisualStyleBackColor = false;
            this.buttonDone_LIV.Click += new System.EventHandler(this.buttonDone_LIV_Click);
            // 
            // buttonHelp_LIV
            // 
            this.buttonHelp_LIV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_LIV.Location = new System.Drawing.Point(723, 17);
            this.buttonHelp_LIV.Name = "buttonHelp_LIV";
            this.buttonHelp_LIV.Size = new System.Drawing.Size(87, 76);
            this.buttonHelp_LIV.TabIndex = 2;
            this.buttonHelp_LIV.Text = "Справка";
            this.buttonHelp_LIV.UseVisualStyleBackColor = false;
            this.buttonHelp_LIV.Click += new System.EventHandler(this.buttonHelp_LIV_Click);
            // 
            // buttonOpen_LIV
            // 
            this.buttonOpen_LIV.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOpen_LIV.Location = new System.Drawing.Point(630, 17);
            this.buttonOpen_LIV.Name = "buttonOpen_LIV";
            this.buttonOpen_LIV.Size = new System.Drawing.Size(87, 76);
            this.buttonOpen_LIV.TabIndex = 3;
            this.buttonOpen_LIV.Text = "Открыть файл";
            this.buttonOpen_LIV.UseVisualStyleBackColor = false;
            this.buttonOpen_LIV.Click += new System.EventHandler(this.buttonOpen_LIV_Click);
            // 
            // textBoxCondition_LIV
            // 
            this.textBoxCondition_LIV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_LIV.Location = new System.Drawing.Point(6, 19);
            this.textBoxCondition_LIV.Multiline = true;
            this.textBoxCondition_LIV.Name = "textBoxCondition_LIV";
            this.textBoxCondition_LIV.ReadOnly = true;
            this.textBoxCondition_LIV.Size = new System.Drawing.Size(498, 52);
            this.textBoxCondition_LIV.TabIndex = 0;
            this.textBoxCondition_LIV.Text = "Прочитать данные из файла InPutFileTask5V1.txt. Вывести в dataGridView. Вывести в" +
    "се положительные числа.Построить диаграмму по этим значениям.";
            // 
            // groupBoxResult_LIV
            // 
            this.groupBoxResult_LIV.Controls.Add(this.dataGridViewResult_LIV);
            this.groupBoxResult_LIV.Location = new System.Drawing.Point(12, 99);
            this.groupBoxResult_LIV.Name = "groupBoxResult_LIV";
            this.groupBoxResult_LIV.Size = new System.Drawing.Size(189, 339);
            this.groupBoxResult_LIV.TabIndex = 4;
            this.groupBoxResult_LIV.TabStop = false;
            this.groupBoxResult_LIV.Text = "Вывод данных:";
            // 
            // chartResult_LIV
            // 
            chartArea3.Name = "ChartArea1";
            this.chartResult_LIV.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartResult_LIV.Legends.Add(legend3);
            this.chartResult_LIV.Location = new System.Drawing.Point(222, 99);
            this.chartResult_LIV.Name = "chartResult_LIV";
            this.chartResult_LIV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartResult_LIV.Series.Add(series3);
            this.chartResult_LIV.Size = new System.Drawing.Size(588, 339);
            this.chartResult_LIV.TabIndex = 0;
            this.chartResult_LIV.Text = "chart1";
            // 
            // dataGridViewResult_LIV
            // 
            this.dataGridViewResult_LIV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_LIV.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewResult_LIV.Name = "dataGridViewResult_LIV";
            this.dataGridViewResult_LIV.Size = new System.Drawing.Size(177, 314);
            this.dataGridViewResult_LIV.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.chartResult_LIV);
            this.Controls.Add(this.groupBoxResult_LIV);
            this.Controls.Add(this.buttonOpen_LIV);
            this.Controls.Add(this.buttonHelp_LIV);
            this.Controls.Add(this.buttonDone_LIV);
            this.Controls.Add(this.groupBoxCondition_LIV);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 1 | Лебедев И.В.";
            this.groupBoxCondition_LIV.ResumeLayout(false);
            this.groupBoxCondition_LIV.PerformLayout();
            this.groupBoxResult_LIV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_LIV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_LIV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_LIV;
        private System.Windows.Forms.TextBox textBoxCondition_LIV;
        private System.Windows.Forms.Button buttonDone_LIV;
        private System.Windows.Forms.Button buttonHelp_LIV;
        private System.Windows.Forms.Button buttonOpen_LIV;
        private System.Windows.Forms.GroupBox groupBoxResult_LIV;
        private System.Windows.Forms.DataGridView dataGridViewResult_LIV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_LIV;
    }
}

