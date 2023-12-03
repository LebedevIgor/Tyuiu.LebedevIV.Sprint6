
namespace Tyuiu.LebedevIV.Sprint6.Task1.V12
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
            this.groupBoxEnter_LIV = new System.Windows.Forms.GroupBox();
            this.groupBoxOut_LIV = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_LIV = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_LIV = new System.Windows.Forms.TextBox();
            this.textBoxEndStep_LIV = new System.Windows.Forms.TextBox();
            this.labelStartStep_LIV = new System.Windows.Forms.Label();
            this.labelEndStep_LIV = new System.Windows.Forms.Label();
            this.buttonHelp_LIV = new System.Windows.Forms.Button();
            this.buttonDone_LIV = new System.Windows.Forms.Button();
            this.textBoxResult_LIV = new System.Windows.Forms.TextBox();
            this.labelResult_LIV = new System.Windows.Forms.Label();
            this.groupBoxCondition_LIV.SuspendLayout();
            this.groupBoxEnter_LIV.SuspendLayout();
            this.groupBoxOut_LIV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_LIV
            // 
            this.groupBoxCondition_LIV.Controls.Add(this.textBoxCondition_LIV);
            this.groupBoxCondition_LIV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_LIV.Name = "groupBoxCondition_LIV";
            this.groupBoxCondition_LIV.Size = new System.Drawing.Size(543, 253);
            this.groupBoxCondition_LIV.TabIndex = 0;
            this.groupBoxCondition_LIV.TabStop = false;
            this.groupBoxCondition_LIV.Text = "Условие";
            // 
            // groupBoxEnter_LIV
            // 
            this.groupBoxEnter_LIV.Controls.Add(this.labelEndStep_LIV);
            this.groupBoxEnter_LIV.Controls.Add(this.labelStartStep_LIV);
            this.groupBoxEnter_LIV.Controls.Add(this.textBoxStartStep_LIV);
            this.groupBoxEnter_LIV.Controls.Add(this.textBoxEndStep_LIV);
            this.groupBoxEnter_LIV.Location = new System.Drawing.Point(12, 271);
            this.groupBoxEnter_LIV.Name = "groupBoxEnter_LIV";
            this.groupBoxEnter_LIV.Size = new System.Drawing.Size(244, 65);
            this.groupBoxEnter_LIV.TabIndex = 0;
            this.groupBoxEnter_LIV.TabStop = false;
            this.groupBoxEnter_LIV.Text = "Ввод данных";
            // 
            // groupBoxOut_LIV
            // 
            this.groupBoxOut_LIV.Controls.Add(this.labelResult_LIV);
            this.groupBoxOut_LIV.Controls.Add(this.textBoxResult_LIV);
            this.groupBoxOut_LIV.Location = new System.Drawing.Point(573, 12);
            this.groupBoxOut_LIV.Name = "groupBoxOut_LIV";
            this.groupBoxOut_LIV.Size = new System.Drawing.Size(244, 324);
            this.groupBoxOut_LIV.TabIndex = 0;
            this.groupBoxOut_LIV.TabStop = false;
            this.groupBoxOut_LIV.Text = "Вывод данных";
            // 
            // textBoxCondition_LIV
            // 
            this.textBoxCondition_LIV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_LIV.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxCondition_LIV.Location = new System.Drawing.Point(6, 19);
            this.textBoxCondition_LIV.Multiline = true;
            this.textBoxCondition_LIV.Name = "textBoxCondition_LIV";
            this.textBoxCondition_LIV.ReadOnly = true;
            this.textBoxCondition_LIV.Size = new System.Drawing.Size(531, 228);
            this.textBoxCondition_LIV.TabIndex = 0;
            this.textBoxCondition_LIV.Text = "Протубулировать функцию sin(x)+(cos(x)+1)/(2-x )+ 2*x на заданном диапозонею.\r\nРе" +
    "зультат вывести в виде таблицы.\r\n\r\n";
            // 
            // textBoxStartStep_LIV
            // 
            this.textBoxStartStep_LIV.Location = new System.Drawing.Point(6, 39);
            this.textBoxStartStep_LIV.Name = "textBoxStartStep_LIV";
            this.textBoxStartStep_LIV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_LIV.TabIndex = 1;
            // 
            // textBoxEndStep_LIV
            // 
            this.textBoxEndStep_LIV.Location = new System.Drawing.Point(126, 39);
            this.textBoxEndStep_LIV.Name = "textBoxEndStep_LIV";
            this.textBoxEndStep_LIV.Size = new System.Drawing.Size(100, 20);
            this.textBoxEndStep_LIV.TabIndex = 2;
            // 
            // labelStartStep_LIV
            // 
            this.labelStartStep_LIV.AutoSize = true;
            this.labelStartStep_LIV.Location = new System.Drawing.Point(6, 23);
            this.labelStartStep_LIV.Name = "labelStartStep_LIV";
            this.labelStartStep_LIV.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_LIV.TabIndex = 3;
            this.labelStartStep_LIV.Text = "Старт шага:";
            // 
            // labelEndStep_LIV
            // 
            this.labelEndStep_LIV.AutoSize = true;
            this.labelEndStep_LIV.Location = new System.Drawing.Point(123, 23);
            this.labelEndStep_LIV.Name = "labelEndStep_LIV";
            this.labelEndStep_LIV.Size = new System.Drawing.Size(69, 13);
            this.labelEndStep_LIV.TabIndex = 4;
            this.labelEndStep_LIV.Text = "Конец шага:";
            // 
            // buttonHelp_LIV
            // 
            this.buttonHelp_LIV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_LIV.Location = new System.Drawing.Point(284, 274);
            this.buttonHelp_LIV.Name = "buttonHelp_LIV";
            this.buttonHelp_LIV.Size = new System.Drawing.Size(92, 62);
            this.buttonHelp_LIV.TabIndex = 5;
            this.buttonHelp_LIV.Text = "Справка";
            this.buttonHelp_LIV.UseVisualStyleBackColor = false;
            this.buttonHelp_LIV.Click += new System.EventHandler(this.buttonHelp_LIV_Click);
            // 
            // buttonDone_LIV
            // 
            this.buttonDone_LIV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_LIV.Location = new System.Drawing.Point(382, 274);
            this.buttonDone_LIV.Name = "buttonDone_LIV";
            this.buttonDone_LIV.Size = new System.Drawing.Size(120, 62);
            this.buttonDone_LIV.TabIndex = 6;
            this.buttonDone_LIV.Text = "Выполнить";
            this.buttonDone_LIV.UseVisualStyleBackColor = false;
            this.buttonDone_LIV.Click += new System.EventHandler(this.buttonDone_LIV_Click);
            // 
            // textBoxResult_LIV
            // 
            this.textBoxResult_LIV.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_LIV.Location = new System.Drawing.Point(6, 35);
            this.textBoxResult_LIV.Multiline = true;
            this.textBoxResult_LIV.Name = "textBoxResult_LIV";
            this.textBoxResult_LIV.ReadOnly = true;
            this.textBoxResult_LIV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_LIV.Size = new System.Drawing.Size(232, 283);
            this.textBoxResult_LIV.TabIndex = 0;
            // 
            // labelResult_LIV
            // 
            this.labelResult_LIV.AutoSize = true;
            this.labelResult_LIV.Location = new System.Drawing.Point(6, 19);
            this.labelResult_LIV.Name = "labelResult_LIV";
            this.labelResult_LIV.Size = new System.Drawing.Size(62, 13);
            this.labelResult_LIV.TabIndex = 1;
            this.labelResult_LIV.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 348);
            this.Controls.Add(this.buttonHelp_LIV);
            this.Controls.Add(this.buttonDone_LIV);
            this.Controls.Add(this.groupBoxEnter_LIV);
            this.Controls.Add(this.groupBoxOut_LIV);
            this.Controls.Add(this.groupBoxCondition_LIV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 12 | Лебедев И.В.";
            this.groupBoxCondition_LIV.ResumeLayout(false);
            this.groupBoxCondition_LIV.PerformLayout();
            this.groupBoxEnter_LIV.ResumeLayout(false);
            this.groupBoxEnter_LIV.PerformLayout();
            this.groupBoxOut_LIV.ResumeLayout(false);
            this.groupBoxOut_LIV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_LIV;
        private System.Windows.Forms.GroupBox groupBoxEnter_LIV;
        private System.Windows.Forms.GroupBox groupBoxOut_LIV;
        private System.Windows.Forms.TextBox textBoxCondition_LIV;
        private System.Windows.Forms.Label labelEndStep_LIV;
        private System.Windows.Forms.Label labelStartStep_LIV;
        private System.Windows.Forms.TextBox textBoxStartStep_LIV;
        private System.Windows.Forms.TextBox textBoxEndStep_LIV;
        private System.Windows.Forms.Button buttonHelp_LIV;
        private System.Windows.Forms.Button buttonDone_LIV;
        private System.Windows.Forms.Label labelResult_LIV;
        private System.Windows.Forms.TextBox textBoxResult_LIV;
    }
}

