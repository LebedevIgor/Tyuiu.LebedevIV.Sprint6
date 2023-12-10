
namespace Tyuiu.LebedevIV.Sprint6.Task4.V25
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonDone_LIV = new System.Windows.Forms.Button();
            this.buttonSave_LIV = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxStartStep_LIV = new System.Windows.Forms.TextBox();
            this.textBoxEndStep_LIV = new System.Windows.Forms.TextBox();
            this.labelStartStep_LIV = new System.Windows.Forms.Label();
            this.labelEndStep_LIV = new System.Windows.Forms.Label();
            this.groupBoxCodition_LIV = new System.Windows.Forms.GroupBox();
            this.groupBoxEnter_LIV = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_LIV = new System.Windows.Forms.TextBox();
            this.groupBoxResult_LIV = new System.Windows.Forms.GroupBox();
            this.chartResult_LIV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxResult_LIV = new System.Windows.Forms.TextBox();
            this.groupBoxCodition_LIV.SuspendLayout();
            this.groupBoxEnter_LIV.SuspendLayout();
            this.groupBoxResult_LIV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_LIV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_LIV
            // 
            this.buttonDone_LIV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_LIV.Location = new System.Drawing.Point(626, 18);
            this.buttonDone_LIV.Name = "buttonDone_LIV";
            this.buttonDone_LIV.Size = new System.Drawing.Size(90, 63);
            this.buttonDone_LIV.TabIndex = 0;
            this.buttonDone_LIV.Text = "Выполнить";
            this.buttonDone_LIV.UseVisualStyleBackColor = false;
            this.buttonDone_LIV.Click += new System.EventHandler(this.buttonDone_LIV_Click);
            // 
            // buttonSave_LIV
            // 
            this.buttonSave_LIV.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSave_LIV.Location = new System.Drawing.Point(722, 18);
            this.buttonSave_LIV.Name = "buttonSave_LIV";
            this.buttonSave_LIV.Size = new System.Drawing.Size(90, 63);
            this.buttonSave_LIV.TabIndex = 1;
            this.buttonSave_LIV.Text = "Сохранить";
            this.buttonSave_LIV.UseVisualStyleBackColor = false;
            this.buttonSave_LIV.Click += new System.EventHandler(this.buttonSave_LIV_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(818, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "Справка";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxStartStep_LIV
            // 
            this.textBoxStartStep_LIV.Location = new System.Drawing.Point(6, 49);
            this.textBoxStartStep_LIV.Name = "textBoxStartStep_LIV";
            this.textBoxStartStep_LIV.Size = new System.Drawing.Size(120, 20);
            this.textBoxStartStep_LIV.TabIndex = 3;
            // 
            // textBoxEndStep_LIV
            // 
            this.textBoxEndStep_LIV.Location = new System.Drawing.Point(132, 49);
            this.textBoxEndStep_LIV.Name = "textBoxEndStep_LIV";
            this.textBoxEndStep_LIV.Size = new System.Drawing.Size(114, 20);
            this.textBoxEndStep_LIV.TabIndex = 4;
            // 
            // labelStartStep_LIV
            // 
            this.labelStartStep_LIV.AutoSize = true;
            this.labelStartStep_LIV.Location = new System.Drawing.Point(6, 31);
            this.labelStartStep_LIV.Name = "labelStartStep_LIV";
            this.labelStartStep_LIV.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_LIV.TabIndex = 5;
            this.labelStartStep_LIV.Text = "Старт шага:";
            // 
            // labelEndStep_LIV
            // 
            this.labelEndStep_LIV.AutoSize = true;
            this.labelEndStep_LIV.Location = new System.Drawing.Point(129, 33);
            this.labelEndStep_LIV.Name = "labelEndStep_LIV";
            this.labelEndStep_LIV.Size = new System.Drawing.Size(69, 13);
            this.labelEndStep_LIV.TabIndex = 6;
            this.labelEndStep_LIV.Text = "Конец шага:";
            // 
            // groupBoxCodition_LIV
            // 
            this.groupBoxCodition_LIV.Controls.Add(this.textBoxCondition_LIV);
            this.groupBoxCodition_LIV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCodition_LIV.Name = "groupBoxCodition_LIV";
            this.groupBoxCodition_LIV.Size = new System.Drawing.Size(350, 87);
            this.groupBoxCodition_LIV.TabIndex = 7;
            this.groupBoxCodition_LIV.TabStop = false;
            this.groupBoxCodition_LIV.Text = "Условие: ";
            // 
            // groupBoxEnter_LIV
            // 
            this.groupBoxEnter_LIV.Controls.Add(this.textBoxStartStep_LIV);
            this.groupBoxEnter_LIV.Controls.Add(this.textBoxEndStep_LIV);
            this.groupBoxEnter_LIV.Controls.Add(this.labelEndStep_LIV);
            this.groupBoxEnter_LIV.Controls.Add(this.labelStartStep_LIV);
            this.groupBoxEnter_LIV.Location = new System.Drawing.Point(369, 12);
            this.groupBoxEnter_LIV.Name = "groupBoxEnter_LIV";
            this.groupBoxEnter_LIV.Size = new System.Drawing.Size(252, 87);
            this.groupBoxEnter_LIV.TabIndex = 8;
            this.groupBoxEnter_LIV.TabStop = false;
            this.groupBoxEnter_LIV.Text = "Ввод данных: ";
            // 
            // textBoxCondition_LIV
            // 
            this.textBoxCondition_LIV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_LIV.Location = new System.Drawing.Point(6, 16);
            this.textBoxCondition_LIV.Multiline = true;
            this.textBoxCondition_LIV.Name = "textBoxCondition_LIV";
            this.textBoxCondition_LIV.ReadOnly = true;
            this.textBoxCondition_LIV.Size = new System.Drawing.Size(338, 65);
            this.textBoxCondition_LIV.TabIndex = 9;
            this.textBoxCondition_LIV.Text = "Протабулировать функцию на заданном диапозоне от -5 до 5\r\nРезуьтат вывести в text" +
    "Box. Построить график функции и сохранить в файл\r\nOutPutFileTask.txt по нажатию " +
    "кнопки.\r\n";
            // 
            // groupBoxResult_LIV
            // 
            this.groupBoxResult_LIV.Controls.Add(this.textBoxResult_LIV);
            this.groupBoxResult_LIV.Location = new System.Drawing.Point(12, 105);
            this.groupBoxResult_LIV.Name = "groupBoxResult_LIV";
            this.groupBoxResult_LIV.Size = new System.Drawing.Size(257, 333);
            this.groupBoxResult_LIV.TabIndex = 9;
            this.groupBoxResult_LIV.TabStop = false;
            this.groupBoxResult_LIV.Text = "Вывод:";
            // 
            // chartResult_LIV
            // 
            chartArea4.Name = "ChartArea1";
            this.chartResult_LIV.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartResult_LIV.Legends.Add(legend4);
            this.chartResult_LIV.Location = new System.Drawing.Point(275, 105);
            this.chartResult_LIV.Name = "chartResult_LIV";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartResult_LIV.Series.Add(series4);
            this.chartResult_LIV.Size = new System.Drawing.Size(633, 333);
            this.chartResult_LIV.TabIndex = 10;
            this.chartResult_LIV.Text = "chart1";
            // 
            // textBoxResult_LIV
            // 
            this.textBoxResult_LIV.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult_LIV.Multiline = true;
            this.textBoxResult_LIV.Name = "textBoxResult_LIV";
            this.textBoxResult_LIV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_LIV.Size = new System.Drawing.Size(245, 308);
            this.textBoxResult_LIV.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 447);
            this.Controls.Add(this.chartResult_LIV);
            this.Controls.Add(this.groupBoxResult_LIV);
            this.Controls.Add(this.groupBoxEnter_LIV);
            this.Controls.Add(this.groupBoxCodition_LIV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonSave_LIV);
            this.Controls.Add(this.buttonDone_LIV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Спринт 6 | Таск 4 | Вариант 25 | Лебедев И.В.";
            this.groupBoxCodition_LIV.ResumeLayout(false);
            this.groupBoxCodition_LIV.PerformLayout();
            this.groupBoxEnter_LIV.ResumeLayout(false);
            this.groupBoxEnter_LIV.PerformLayout();
            this.groupBoxResult_LIV.ResumeLayout(false);
            this.groupBoxResult_LIV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_LIV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_LIV;
        private System.Windows.Forms.Button buttonSave_LIV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxStartStep_LIV;
        private System.Windows.Forms.TextBox textBoxEndStep_LIV;
        private System.Windows.Forms.Label labelStartStep_LIV;
        private System.Windows.Forms.Label labelEndStep_LIV;
        private System.Windows.Forms.GroupBox groupBoxCodition_LIV;
        private System.Windows.Forms.TextBox textBoxCondition_LIV;
        private System.Windows.Forms.GroupBox groupBoxEnter_LIV;
        private System.Windows.Forms.GroupBox groupBoxResult_LIV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_LIV;
        private System.Windows.Forms.TextBox textBoxResult_LIV;
    }
}

