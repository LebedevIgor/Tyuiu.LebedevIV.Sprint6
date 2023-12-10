
namespace Tyuiu.LebedevIV.Sprint6.Task6.V22
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAbout_LIV = new System.Windows.Forms.PictureBox();
            this.textBoxAbout_LIV = new System.Windows.Forms.TextBox();
            this.buttonOK_LIV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_LIV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAbout_LIV
            // 
            this.pictureBoxAbout_LIV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAbout_LIV.BackgroundImage")));
            this.pictureBoxAbout_LIV.Location = new System.Drawing.Point(12, 11);
            this.pictureBoxAbout_LIV.Name = "pictureBoxAbout_LIV";
            this.pictureBoxAbout_LIV.Size = new System.Drawing.Size(115, 190);
            this.pictureBoxAbout_LIV.TabIndex = 0;
            this.pictureBoxAbout_LIV.TabStop = false;
            // 
            // textBoxAbout_LIV
            // 
            this.textBoxAbout_LIV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAbout_LIV.Location = new System.Drawing.Point(133, 11);
            this.textBoxAbout_LIV.Multiline = true;
            this.textBoxAbout_LIV.Name = "textBoxAbout_LIV";
            this.textBoxAbout_LIV.ReadOnly = true;
            this.textBoxAbout_LIV.Size = new System.Drawing.Size(277, 190);
            this.textBoxAbout_LIV.TabIndex = 1;
            this.textBoxAbout_LIV.Text = "Разработчик: Лебедев И.В.\r\nгруппа ИИПб-23-3\r\n\r\nПрограммма разработана в рамках из" +
    "учения языка C#\r\n\r\nТИУ(с) 2023\r\nВШЦТ(с) 2023\r\n\r\nВнутренее имя: Tyuiu.LebedevIV.S" +
    "print6.Task6.V22\r\n";
            // 
            // buttonOK_LIV
            // 
            this.buttonOK_LIV.Location = new System.Drawing.Point(335, 178);
            this.buttonOK_LIV.Name = "buttonOK_LIV";
            this.buttonOK_LIV.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_LIV.TabIndex = 2;
            this.buttonOK_LIV.Text = "Ок";
            this.buttonOK_LIV.UseVisualStyleBackColor = true;
            this.buttonOK_LIV.Click += new System.EventHandler(this.buttonOK_LIV_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 213);
            this.Controls.Add(this.buttonOK_LIV);
            this.Controls.Add(this.textBoxAbout_LIV);
            this.Controls.Add(this.pictureBoxAbout_LIV);
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_LIV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAbout_LIV;
        private System.Windows.Forms.TextBox textBoxAbout_LIV;
        private System.Windows.Forms.Button buttonOK_LIV;
    }
}