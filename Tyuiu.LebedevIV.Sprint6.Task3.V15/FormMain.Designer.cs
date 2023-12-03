
namespace Tyuiu.LebedevIV.Sprint6.Task3.V15
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
            this.groupBoxCondition_LIV = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxResult_LIV = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_LIV = new System.Windows.Forms.TextBox();
            this.dataGridViewCondition_LIV = new System.Windows.Forms.DataGridView();
            this.buttonDone_LIV = new System.Windows.Forms.Button();
            this.buttonHelp_LIV = new System.Windows.Forms.Button();
            this.textBoxResult_LIV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCondition_LIV.SuspendLayout();
            this.groupBoxResult_LIV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCondition_LIV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_LIV
            // 
            this.groupBoxCondition_LIV.Controls.Add(this.dataGridViewCondition_LIV);
            this.groupBoxCondition_LIV.Controls.Add(this.textBoxCondition_LIV);
            this.groupBoxCondition_LIV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_LIV.Name = "groupBoxCondition_LIV";
            this.groupBoxCondition_LIV.Size = new System.Drawing.Size(380, 179);
            this.groupBoxCondition_LIV.TabIndex = 0;
            this.groupBoxCondition_LIV.TabStop = false;
            this.groupBoxCondition_LIV.Text = "Условие";
            // 
            // groupBoxResult_LIV
            // 
            this.groupBoxResult_LIV.Controls.Add(this.label1);
            this.groupBoxResult_LIV.Controls.Add(this.textBoxResult_LIV);
            this.groupBoxResult_LIV.Location = new System.Drawing.Point(402, 12);
            this.groupBoxResult_LIV.Name = "groupBoxResult_LIV";
            this.groupBoxResult_LIV.Size = new System.Drawing.Size(121, 79);
            this.groupBoxResult_LIV.TabIndex = 0;
            this.groupBoxResult_LIV.TabStop = false;
            this.groupBoxResult_LIV.Text = "Вывод данных";
            // 
            // textBoxCondition_LIV
            // 
            this.textBoxCondition_LIV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_LIV.Location = new System.Drawing.Point(6, 19);
            this.textBoxCondition_LIV.Multiline = true;
            this.textBoxCondition_LIV.Name = "textBoxCondition_LIV";
            this.textBoxCondition_LIV.ReadOnly = true;
            this.textBoxCondition_LIV.Size = new System.Drawing.Size(202, 150);
            this.textBoxCondition_LIV.TabIndex = 1;
            this.textBoxCondition_LIV.Text = "Дана матрица 5 на 5\r\n33  28  31  19   4\r\n1  32  -3 -17 -12\r\n24 -19  26  31  -3\r\n3" +
    "0 -16  29  28   8\r\n30   5  11   7  32\r\nВыполнить сортировку по возрастанию в тре" +
    "тьем столбце\r\n";
            // 
            // dataGridViewCondition_LIV
            // 
            this.dataGridViewCondition_LIV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCondition_LIV.ColumnHeadersVisible = false;
            this.dataGridViewCondition_LIV.Location = new System.Drawing.Point(214, 19);
            this.dataGridViewCondition_LIV.Name = "dataGridViewCondition_LIV";
            this.dataGridViewCondition_LIV.RowHeadersVisible = false;
            this.dataGridViewCondition_LIV.Size = new System.Drawing.Size(160, 150);
            this.dataGridViewCondition_LIV.TabIndex = 2;
            // 
            // buttonDone_LIV
            // 
            this.buttonDone_LIV.Location = new System.Drawing.Point(448, 158);
            this.buttonDone_LIV.Name = "buttonDone_LIV";
            this.buttonDone_LIV.Size = new System.Drawing.Size(75, 23);
            this.buttonDone_LIV.TabIndex = 1;
            this.buttonDone_LIV.Text = "Выполнить";
            this.buttonDone_LIV.UseVisualStyleBackColor = true;
            this.buttonDone_LIV.Click += new System.EventHandler(this.buttonDone_LIV_Click);
            // 
            // buttonHelp_LIV
            // 
            this.buttonHelp_LIV.Location = new System.Drawing.Point(402, 158);
            this.buttonHelp_LIV.Name = "buttonHelp_LIV";
            this.buttonHelp_LIV.Size = new System.Drawing.Size(24, 23);
            this.buttonHelp_LIV.TabIndex = 2;
            this.buttonHelp_LIV.Text = "?";
            this.buttonHelp_LIV.UseVisualStyleBackColor = true;
            this.buttonHelp_LIV.Click += new System.EventHandler(this.buttonHelp_LIV_Click);
            // 
            // textBoxResult_LIV
            // 
            this.textBoxResult_LIV.Location = new System.Drawing.Point(6, 35);
            this.textBoxResult_LIV.Name = "textBoxResult_LIV";
            this.textBoxResult_LIV.ReadOnly = true;
            this.textBoxResult_LIV.Size = new System.Drawing.Size(109, 20);
            this.textBoxResult_LIV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 193);
            this.Controls.Add(this.buttonHelp_LIV);
            this.Controls.Add(this.buttonDone_LIV);
            this.Controls.Add(this.groupBoxResult_LIV);
            this.Controls.Add(this.groupBoxCondition_LIV);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 15 | Лебедев И.В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_LIV.ResumeLayout(false);
            this.groupBoxCondition_LIV.PerformLayout();
            this.groupBoxResult_LIV.ResumeLayout(false);
            this.groupBoxResult_LIV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCondition_LIV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_LIV;
        private System.Windows.Forms.DataGridView dataGridViewCondition_LIV;
        private System.Windows.Forms.TextBox textBoxCondition_LIV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxResult_LIV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResult_LIV;
        private System.Windows.Forms.Button buttonDone_LIV;
        private System.Windows.Forms.Button buttonHelp_LIV;
    }
}

