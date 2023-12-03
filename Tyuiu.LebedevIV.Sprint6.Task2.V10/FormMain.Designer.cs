
namespace Tyuiu.LebedevIV.Sprint6.Task2.V10
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBoxEnter_LIV = new System.Windows.Forms.GroupBox();
            this.labelEndStep_LIV = new System.Windows.Forms.Label();
            this.textBoxStopStep_LIV = new System.Windows.Forms.TextBox();
            this.labelStartStep_LIV = new System.Windows.Forms.Label();
            this.textBoxStartStep_LIV = new System.Windows.Forms.TextBox();
            this.groupBoxOut_LIV = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_LIV = new System.Windows.Forms.DataGridView();
            this.ColumnX_LIV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnF_LIV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult_LIV = new System.Windows.Forms.Label();
            this.chartResult_LIV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonHelp_LIV = new System.Windows.Forms.Button();
            this.buttonDone_LIV = new System.Windows.Forms.Button();
            this.groupBoxCondition_LIV.SuspendLayout();
            this.groupBoxEnter_LIV.SuspendLayout();
            this.groupBoxOut_LIV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_LIV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_LIV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_LIV
            // 
            this.groupBoxCondition_LIV.Controls.Add(this.textBox3);
            this.groupBoxCondition_LIV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_LIV.Name = "groupBoxCondition_LIV";
            this.groupBoxCondition_LIV.Size = new System.Drawing.Size(506, 307);
            this.groupBoxCondition_LIV.TabIndex = 0;
            this.groupBoxCondition_LIV.TabStop = false;
            this.groupBoxCondition_LIV.Text = "Условие";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 33);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(494, 268);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Протабулировать функцию 2*x-4+(2*x-1)/(sin(x)+1) на заданном диапозоне.\r\nРезульта" +
    "т вывести в DataGridView и построить график функции.\r\n";
            // 
            // groupBoxEnter_LIV
            // 
            this.groupBoxEnter_LIV.Controls.Add(this.labelEndStep_LIV);
            this.groupBoxEnter_LIV.Controls.Add(this.textBoxStopStep_LIV);
            this.groupBoxEnter_LIV.Controls.Add(this.labelStartStep_LIV);
            this.groupBoxEnter_LIV.Controls.Add(this.textBoxStartStep_LIV);
            this.groupBoxEnter_LIV.Location = new System.Drawing.Point(18, 325);
            this.groupBoxEnter_LIV.Name = "groupBoxEnter_LIV";
            this.groupBoxEnter_LIV.Size = new System.Drawing.Size(285, 74);
            this.groupBoxEnter_LIV.TabIndex = 0;
            this.groupBoxEnter_LIV.TabStop = false;
            this.groupBoxEnter_LIV.Text = "Ввод данных";
            // 
            // labelEndStep_LIV
            // 
            this.labelEndStep_LIV.AutoSize = true;
            this.labelEndStep_LIV.Location = new System.Drawing.Point(153, 16);
            this.labelEndStep_LIV.Name = "labelEndStep_LIV";
            this.labelEndStep_LIV.Size = new System.Drawing.Size(69, 13);
            this.labelEndStep_LIV.TabIndex = 4;
            this.labelEndStep_LIV.Text = "Конец шага:";
            // 
            // textBoxStopStep_LIV
            // 
            this.textBoxStopStep_LIV.Location = new System.Drawing.Point(156, 35);
            this.textBoxStopStep_LIV.Name = "textBoxStopStep_LIV";
            this.textBoxStopStep_LIV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_LIV.TabIndex = 0;
            // 
            // labelStartStep_LIV
            // 
            this.labelStartStep_LIV.AutoSize = true;
            this.labelStartStep_LIV.Location = new System.Drawing.Point(12, 16);
            this.labelStartStep_LIV.Name = "labelStartStep_LIV";
            this.labelStartStep_LIV.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_LIV.TabIndex = 3;
            this.labelStartStep_LIV.Text = "Старт шага:";
            // 
            // textBoxStartStep_LIV
            // 
            this.textBoxStartStep_LIV.Location = new System.Drawing.Point(15, 35);
            this.textBoxStartStep_LIV.Name = "textBoxStartStep_LIV";
            this.textBoxStartStep_LIV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_LIV.TabIndex = 1;
            // 
            // groupBoxOut_LIV
            // 
            this.groupBoxOut_LIV.Controls.Add(this.dataGridViewResult_LIV);
            this.groupBoxOut_LIV.Controls.Add(this.labelResult_LIV);
            this.groupBoxOut_LIV.Controls.Add(this.chartResult_LIV);
            this.groupBoxOut_LIV.Location = new System.Drawing.Point(524, 12);
            this.groupBoxOut_LIV.Name = "groupBoxOut_LIV";
            this.groupBoxOut_LIV.Size = new System.Drawing.Size(546, 387);
            this.groupBoxOut_LIV.TabIndex = 0;
            this.groupBoxOut_LIV.TabStop = false;
            this.groupBoxOut_LIV.Text = "Вывод данных";
            // 
            // dataGridViewResult_LIV
            // 
            this.dataGridViewResult_LIV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_LIV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX_LIV,
            this.ColumnF_LIV});
            this.dataGridViewResult_LIV.Location = new System.Drawing.Point(6, 49);
            this.dataGridViewResult_LIV.Name = "dataGridViewResult_LIV";
            this.dataGridViewResult_LIV.RowHeadersVisible = false;
            this.dataGridViewResult_LIV.Size = new System.Drawing.Size(104, 332);
            this.dataGridViewResult_LIV.TabIndex = 8;
            // 
            // ColumnX_LIV
            // 
            this.ColumnX_LIV.HeaderText = "X";
            this.ColumnX_LIV.Name = "ColumnX_LIV";
            this.ColumnX_LIV.Width = 50;
            // 
            // ColumnF_LIV
            // 
            this.ColumnF_LIV.HeaderText = "F(X)";
            this.ColumnF_LIV.Name = "ColumnF_LIV";
            this.ColumnF_LIV.Width = 50;
            // 
            // labelResult_LIV
            // 
            this.labelResult_LIV.AutoSize = true;
            this.labelResult_LIV.Location = new System.Drawing.Point(6, 33);
            this.labelResult_LIV.Name = "labelResult_LIV";
            this.labelResult_LIV.Size = new System.Drawing.Size(62, 13);
            this.labelResult_LIV.TabIndex = 7;
            this.labelResult_LIV.Text = "Результат:";
            // 
            // chartResult_LIV
            // 
            chartArea3.Name = "ChartArea1";
            this.chartResult_LIV.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartResult_LIV.Legends.Add(legend3);
            this.chartResult_LIV.Location = new System.Drawing.Point(116, 49);
            this.chartResult_LIV.Name = "chartResult_LIV";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartResult_LIV.Series.Add(series3);
            this.chartResult_LIV.Size = new System.Drawing.Size(424, 332);
            this.chartResult_LIV.TabIndex = 6;
            this.chartResult_LIV.Text = "chart1";
            // 
            // buttonHelp_LIV
            // 
            this.buttonHelp_LIV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_LIV.Location = new System.Drawing.Point(324, 325);
            this.buttonHelp_LIV.Name = "buttonHelp_LIV";
            this.buttonHelp_LIV.Size = new System.Drawing.Size(75, 74);
            this.buttonHelp_LIV.TabIndex = 5;
            this.buttonHelp_LIV.Text = "Справка";
            this.buttonHelp_LIV.UseVisualStyleBackColor = false;
            this.buttonHelp_LIV.Click += new System.EventHandler(this.buttonHelp_LIV_Click);
            // 
            // buttonDone_LIV
            // 
            this.buttonDone_LIV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_LIV.Location = new System.Drawing.Point(405, 325);
            this.buttonDone_LIV.Name = "buttonDone_LIV";
            this.buttonDone_LIV.Size = new System.Drawing.Size(113, 74);
            this.buttonDone_LIV.TabIndex = 6;
            this.buttonDone_LIV.Text = "Выполнить";
            this.buttonDone_LIV.UseVisualStyleBackColor = false;
            this.buttonDone_LIV.Click += new System.EventHandler(this.buttonDone_LIV_Click);
            this.buttonDone_LIV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_LIV_MouseDown);
            this.buttonDone_LIV.MouseEnter += new System.EventHandler(this.buttonDone_LIV_MouseEnter);
            this.buttonDone_LIV.MouseLeave += new System.EventHandler(this.buttonDone_LIV_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 411);
            this.Controls.Add(this.buttonDone_LIV);
            this.Controls.Add(this.groupBoxEnter_LIV);
            this.Controls.Add(this.groupBoxOut_LIV);
            this.Controls.Add(this.groupBoxCondition_LIV);
            this.Controls.Add(this.buttonHelp_LIV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск2 | Вариант 10 | Лебедев И.В.";
            this.groupBoxCondition_LIV.ResumeLayout(false);
            this.groupBoxCondition_LIV.PerformLayout();
            this.groupBoxEnter_LIV.ResumeLayout(false);
            this.groupBoxEnter_LIV.PerformLayout();
            this.groupBoxOut_LIV.ResumeLayout(false);
            this.groupBoxOut_LIV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_LIV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_LIV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_LIV;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBoxEnter_LIV;
        private System.Windows.Forms.Label labelEndStep_LIV;
        private System.Windows.Forms.TextBox textBoxStopStep_LIV;
        private System.Windows.Forms.Label labelStartStep_LIV;
        private System.Windows.Forms.TextBox textBoxStartStep_LIV;
        private System.Windows.Forms.GroupBox groupBoxOut_LIV;
        private System.Windows.Forms.DataGridView dataGridViewResult_LIV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_LIV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnF_LIV;
        private System.Windows.Forms.Label labelResult_LIV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_LIV;
        private System.Windows.Forms.Button buttonHelp_LIV;
        private System.Windows.Forms.Button buttonDone_LIV;
    }
}

