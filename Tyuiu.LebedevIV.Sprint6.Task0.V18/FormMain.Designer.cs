
namespace Tyuiu.LebedevIV.Sprint6.Task0.V18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCondition_LIV = new System.Windows.Forms.GroupBox();
            this.pictureBox_LIV = new System.Windows.Forms.PictureBox();
            this.labelCondition_LIV = new System.Windows.Forms.Label();
            this.groupBoxEnter_LIV = new System.Windows.Forms.GroupBox();
            this.textBoxX_LIV = new System.Windows.Forms.TextBox();
            this.labelVarX_LIV = new System.Windows.Forms.Label();
            this.groupBoxOut_LIV = new System.Windows.Forms.GroupBox();
            this.labelResult_LIV = new System.Windows.Forms.Label();
            this.textBoxResult_LIV = new System.Windows.Forms.TextBox();
            this.buttonDone_LIV = new System.Windows.Forms.Button();
            this.buttonHelp_LIV = new System.Windows.Forms.Button();
            this.groupBoxCondition_LIV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LIV)).BeginInit();
            this.groupBoxEnter_LIV.SuspendLayout();
            this.groupBoxOut_LIV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_LIV
            // 
            this.groupBoxCondition_LIV.Controls.Add(this.pictureBox_LIV);
            this.groupBoxCondition_LIV.Controls.Add(this.labelCondition_LIV);
            this.groupBoxCondition_LIV.Location = new System.Drawing.Point(12, 23);
            this.groupBoxCondition_LIV.Name = "groupBoxCondition_LIV";
            this.groupBoxCondition_LIV.Size = new System.Drawing.Size(776, 228);
            this.groupBoxCondition_LIV.TabIndex = 0;
            this.groupBoxCondition_LIV.TabStop = false;
            this.groupBoxCondition_LIV.Text = "Условие";
            // 
            // pictureBox_LIV
            // 
            this.pictureBox_LIV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_LIV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_LIV.Image")));
            this.pictureBox_LIV.Location = new System.Drawing.Point(646, 19);
            this.pictureBox_LIV.Name = "pictureBox_LIV";
            this.pictureBox_LIV.Size = new System.Drawing.Size(124, 65);
            this.pictureBox_LIV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_LIV.TabIndex = 1;
            this.pictureBox_LIV.TabStop = false;
            // 
            // labelCondition_LIV
            // 
            this.labelCondition_LIV.AutoSize = true;
            this.labelCondition_LIV.Location = new System.Drawing.Point(16, 27);
            this.labelCondition_LIV.Name = "labelCondition_LIV";
            this.labelCondition_LIV.Size = new System.Drawing.Size(186, 13);
            this.labelCondition_LIV.TabIndex = 0;
            this.labelCondition_LIV.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxEnter_LIV
            // 
            this.groupBoxEnter_LIV.Controls.Add(this.textBoxX_LIV);
            this.groupBoxEnter_LIV.Controls.Add(this.labelVarX_LIV);
            this.groupBoxEnter_LIV.Location = new System.Drawing.Point(12, 257);
            this.groupBoxEnter_LIV.Name = "groupBoxEnter_LIV";
            this.groupBoxEnter_LIV.Size = new System.Drawing.Size(570, 126);
            this.groupBoxEnter_LIV.TabIndex = 0;
            this.groupBoxEnter_LIV.TabStop = false;
            this.groupBoxEnter_LIV.Text = "Ввод данных";
            // 
            // textBoxX_LIV
            // 
            this.textBoxX_LIV.Location = new System.Drawing.Point(6, 53);
            this.textBoxX_LIV.Name = "textBoxX_LIV";
            this.textBoxX_LIV.Size = new System.Drawing.Size(100, 20);
            this.textBoxX_LIV.TabIndex = 2;
            this.textBoxX_LIV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxX_LIV_KeyPress);
            // 
            // labelVarX_LIV
            // 
            this.labelVarX_LIV.AutoSize = true;
            this.labelVarX_LIV.Location = new System.Drawing.Point(6, 37);
            this.labelVarX_LIV.Name = "labelVarX_LIV";
            this.labelVarX_LIV.Size = new System.Drawing.Size(84, 13);
            this.labelVarX_LIV.TabIndex = 6;
            this.labelVarX_LIV.Text = "Переменная X:";
            // 
            // groupBoxOut_LIV
            // 
            this.groupBoxOut_LIV.Controls.Add(this.labelResult_LIV);
            this.groupBoxOut_LIV.Controls.Add(this.textBoxResult_LIV);
            this.groupBoxOut_LIV.Location = new System.Drawing.Point(588, 257);
            this.groupBoxOut_LIV.Name = "groupBoxOut_LIV";
            this.groupBoxOut_LIV.Size = new System.Drawing.Size(200, 126);
            this.groupBoxOut_LIV.TabIndex = 0;
            this.groupBoxOut_LIV.TabStop = false;
            this.groupBoxOut_LIV.Text = "Вывод данных";
            // 
            // labelResult_LIV
            // 
            this.labelResult_LIV.AutoSize = true;
            this.labelResult_LIV.Location = new System.Drawing.Point(6, 37);
            this.labelResult_LIV.Name = "labelResult_LIV";
            this.labelResult_LIV.Size = new System.Drawing.Size(62, 13);
            this.labelResult_LIV.TabIndex = 9;
            this.labelResult_LIV.Text = "Результат:";
            // 
            // textBoxResult_LIV
            // 
            this.textBoxResult_LIV.Location = new System.Drawing.Point(6, 53);
            this.textBoxResult_LIV.Name = "textBoxResult_LIV";
            this.textBoxResult_LIV.ReadOnly = true;
            this.textBoxResult_LIV.Size = new System.Drawing.Size(188, 20);
            this.textBoxResult_LIV.TabIndex = 5;
            // 
            // buttonDone_LIV
            // 
            this.buttonDone_LIV.Location = new System.Drawing.Point(701, 389);
            this.buttonDone_LIV.Name = "buttonDone_LIV";
            this.buttonDone_LIV.Size = new System.Drawing.Size(87, 33);
            this.buttonDone_LIV.TabIndex = 1;
            this.buttonDone_LIV.Text = "Выполнить";
            this.buttonDone_LIV.UseVisualStyleBackColor = true;
            this.buttonDone_LIV.Click += new System.EventHandler(this.buttonDone_LIV_Click);
            // 
            // buttonHelp_LIV
            // 
            this.buttonHelp_LIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_LIV.Location = new System.Drawing.Point(649, 389);
            this.buttonHelp_LIV.Name = "buttonHelp_LIV";
            this.buttonHelp_LIV.Size = new System.Drawing.Size(39, 33);
            this.buttonHelp_LIV.TabIndex = 2;
            this.buttonHelp_LIV.Text = "?";
            this.buttonHelp_LIV.UseVisualStyleBackColor = true;
            this.buttonHelp_LIV.Click += new System.EventHandler(this.buttonHelp_LIV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_LIV);
            this.Controls.Add(this.buttonDone_LIV);
            this.Controls.Add(this.groupBoxOut_LIV);
            this.Controls.Add(this.groupBoxEnter_LIV);
            this.Controls.Add(this.groupBoxCondition_LIV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = " Спринт 6 | Таск 0 | Вариант 18 | Лебедев И.В.";
            this.groupBoxCondition_LIV.ResumeLayout(false);
            this.groupBoxCondition_LIV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LIV)).EndInit();
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
        private System.Windows.Forms.Button buttonDone_LIV;
        private System.Windows.Forms.Button buttonHelp_LIV;
        private System.Windows.Forms.PictureBox pictureBox_LIV;
        private System.Windows.Forms.Label labelCondition_LIV;
        private System.Windows.Forms.TextBox textBoxX_LIV;
        private System.Windows.Forms.Label labelVarX_LIV;
        private System.Windows.Forms.Label labelResult_LIV;
        private System.Windows.Forms.TextBox textBoxResult_LIV;
    }
}

