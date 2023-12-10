
namespace Tyuiu.LebedevIV.Sprint6.Task7.V10
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PanelTop_LIV = new System.Windows.Forms.Panel();
            this.ButtonInfo_LIV = new System.Windows.Forms.Button();
            this.ButtonSave_LIV = new System.Windows.Forms.Button();
            this.ButtonDone_LIV = new System.Windows.Forms.Button();
            this.ButtonOpen_LIV = new System.Windows.Forms.Button();
            this.PanelTask_LIV = new System.Windows.Forms.Panel();
            this.GroupBoxTask_LIV = new System.Windows.Forms.GroupBox();
            this.TextBoxTask_LIV = new System.Windows.Forms.TextBox();
            this.PanelLeft_LIV = new System.Windows.Forms.Panel();
            this.GroupBoxInput_LIV = new System.Windows.Forms.GroupBox();
            this.DataGridViewInput_LIV = new System.Windows.Forms.DataGridView();
            this.PanelFill_LIV = new System.Windows.Forms.Panel();
            this.GroupBoxOutput_LIV = new System.Windows.Forms.GroupBox();
            this.DataGridViewOutput_LIV = new System.Windows.Forms.DataGridView();
            this.Splitter_LIV = new System.Windows.Forms.Splitter();
            this.OpenFileDialog_LIV = new System.Windows.Forms.OpenFileDialog();
            this.ToolTip_LIV = new System.Windows.Forms.ToolTip(this.components);
            this.SaveFileDialog_LIV = new System.Windows.Forms.SaveFileDialog();
            this.PanelTop_LIV.SuspendLayout();
            this.PanelTask_LIV.SuspendLayout();
            this.GroupBoxTask_LIV.SuspendLayout();
            this.PanelLeft_LIV.SuspendLayout();
            this.GroupBoxInput_LIV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInput_LIV)).BeginInit();
            this.PanelFill_LIV.SuspendLayout();
            this.GroupBoxOutput_LIV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOutput_LIV)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop_LIV
            // 
            this.PanelTop_LIV.Controls.Add(this.ButtonInfo_LIV);
            this.PanelTop_LIV.Controls.Add(this.ButtonSave_LIV);
            this.PanelTop_LIV.Controls.Add(this.ButtonDone_LIV);
            this.PanelTop_LIV.Controls.Add(this.ButtonOpen_LIV);
            this.PanelTop_LIV.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop_LIV.Location = new System.Drawing.Point(0, 0);
            this.PanelTop_LIV.Name = "PanelTop_LIV";
            this.PanelTop_LIV.Size = new System.Drawing.Size(904, 100);
            this.PanelTop_LIV.TabIndex = 0;
            // 
            // ButtonInfo_LIV
            // 
            this.ButtonInfo_LIV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonInfo_LIV.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonInfo_LIV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonInfo_LIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInfo_LIV.Image = ((System.Drawing.Image)(resources.GetObject("ButtonInfo_LIV.Image")));
            this.ButtonInfo_LIV.Location = new System.Drawing.Point(783, 12);
            this.ButtonInfo_LIV.Name = "ButtonInfo_LIV";
            this.ButtonInfo_LIV.Size = new System.Drawing.Size(106, 82);
            this.ButtonInfo_LIV.TabIndex = 3;
            this.ButtonInfo_LIV.UseVisualStyleBackColor = false;
            this.ButtonInfo_LIV.Click += new System.EventHandler(this.ButtonInfo_LIV_Click);
            // 
            // ButtonSave_LIV
            // 
            this.ButtonSave_LIV.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonSave_LIV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonSave_LIV.Enabled = false;
            this.ButtonSave_LIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave_LIV.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSave_LIV.Image")));
            this.ButtonSave_LIV.Location = new System.Drawing.Point(225, 12);
            this.ButtonSave_LIV.Name = "ButtonSave_LIV";
            this.ButtonSave_LIV.Size = new System.Drawing.Size(100, 82);
            this.ButtonSave_LIV.TabIndex = 2;
            this.ToolTip_LIV.SetToolTip(this.ButtonSave_LIV, "Сохранить обработанные данные в файл в формате CSV");
            this.ButtonSave_LIV.UseVisualStyleBackColor = false;
            this.ButtonSave_LIV.Click += new System.EventHandler(this.ButtonSave_LIV_Click);
            this.ButtonSave_LIV.MouseEnter += new System.EventHandler(this.ButtonSave_LIV_MouseEnter);
            // 
            // ButtonDone_LIV
            // 
            this.ButtonDone_LIV.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonDone_LIV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonDone_LIV.Enabled = false;
            this.ButtonDone_LIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDone_LIV.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDone_LIV.Image")));
            this.ButtonDone_LIV.Location = new System.Drawing.Point(119, 12);
            this.ButtonDone_LIV.Name = "ButtonDone_LIV";
            this.ButtonDone_LIV.Size = new System.Drawing.Size(100, 82);
            this.ButtonDone_LIV.TabIndex = 1;
            this.ToolTip_LIV.SetToolTip(this.ButtonDone_LIV, "Выполнить обработку данных");
            this.ButtonDone_LIV.UseVisualStyleBackColor = false;
            this.ButtonDone_LIV.Click += new System.EventHandler(this.ButtonDone_LIV_Click);
            this.ButtonDone_LIV.MouseEnter += new System.EventHandler(this.ButtonDone_LIV_MouseEnter);
            // 
            // ButtonOpen_LIV
            // 
            this.ButtonOpen_LIV.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonOpen_LIV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonOpen_LIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOpen_LIV.Image = ((System.Drawing.Image)(resources.GetObject("ButtonOpen_LIV.Image")));
            this.ButtonOpen_LIV.Location = new System.Drawing.Point(12, 12);
            this.ButtonOpen_LIV.Name = "ButtonOpen_LIV";
            this.ButtonOpen_LIV.Size = new System.Drawing.Size(101, 82);
            this.ButtonOpen_LIV.TabIndex = 0;
            this.ToolTip_LIV.SetToolTip(this.ButtonOpen_LIV, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.ButtonOpen_LIV.UseVisualStyleBackColor = false;
            this.ButtonOpen_LIV.Click += new System.EventHandler(this.ButtonOpen_LIV_Click);
            this.ButtonOpen_LIV.MouseEnter += new System.EventHandler(this.ButtonOpen_LIV_MouseEnter);
            // 
            // PanelTask_LIV
            // 
            this.PanelTask_LIV.Controls.Add(this.GroupBoxTask_LIV);
            this.PanelTask_LIV.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTask_LIV.Location = new System.Drawing.Point(0, 100);
            this.PanelTask_LIV.Name = "PanelTask_LIV";
            this.PanelTask_LIV.Size = new System.Drawing.Size(904, 100);
            this.PanelTask_LIV.TabIndex = 1;
            // 
            // GroupBoxTask_LIV
            // 
            this.GroupBoxTask_LIV.Controls.Add(this.TextBoxTask_LIV);
            this.GroupBoxTask_LIV.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxTask_LIV.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxTask_LIV.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxTask_LIV.Name = "GroupBoxTask_LIV";
            this.GroupBoxTask_LIV.Size = new System.Drawing.Size(904, 100);
            this.GroupBoxTask_LIV.TabIndex = 0;
            this.GroupBoxTask_LIV.TabStop = false;
            this.GroupBoxTask_LIV.Text = "Условие";
            // 
            // TextBoxTask_LIV
            // 
            this.TextBoxTask_LIV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTask_LIV.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxTask_LIV.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTask_LIV.Location = new System.Drawing.Point(3, 22);
            this.TextBoxTask_LIV.Multiline = true;
            this.TextBoxTask_LIV.Name = "TextBoxTask_LIV";
            this.TextBoxTask_LIV.ReadOnly = true;
            this.TextBoxTask_LIV.Size = new System.Drawing.Size(898, 72);
            this.TextBoxTask_LIV.TabIndex = 0;
            this.TextBoxTask_LIV.TabStop = false;
            this.TextBoxTask_LIV.Text = resources.GetString("TextBoxTask_LIV.Text");
            // 
            // PanelLeft_LIV
            // 
            this.PanelLeft_LIV.Controls.Add(this.GroupBoxInput_LIV);
            this.PanelLeft_LIV.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft_LIV.Location = new System.Drawing.Point(0, 200);
            this.PanelLeft_LIV.Name = "PanelLeft_LIV";
            this.PanelLeft_LIV.Size = new System.Drawing.Size(438, 261);
            this.PanelLeft_LIV.TabIndex = 2;
            // 
            // GroupBoxInput_LIV
            // 
            this.GroupBoxInput_LIV.Controls.Add(this.DataGridViewInput_LIV);
            this.GroupBoxInput_LIV.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBoxInput_LIV.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxInput_LIV.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxInput_LIV.Name = "GroupBoxInput_LIV";
            this.GroupBoxInput_LIV.Size = new System.Drawing.Size(432, 261);
            this.GroupBoxInput_LIV.TabIndex = 0;
            this.GroupBoxInput_LIV.TabStop = false;
            this.GroupBoxInput_LIV.Text = "Ввод";
            // 
            // DataGridViewInput_LIV
            // 
            this.DataGridViewInput_LIV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewInput_LIV.ColumnHeadersVisible = false;
            this.DataGridViewInput_LIV.Dock = System.Windows.Forms.DockStyle.Left;
            this.DataGridViewInput_LIV.Location = new System.Drawing.Point(3, 22);
            this.DataGridViewInput_LIV.Name = "DataGridViewInput_LIV";
            this.DataGridViewInput_LIV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewInput_LIV.Size = new System.Drawing.Size(426, 236);
            this.DataGridViewInput_LIV.TabIndex = 0;
            // 
            // PanelFill_LIV
            // 
            this.PanelFill_LIV.Controls.Add(this.GroupBoxOutput_LIV);
            this.PanelFill_LIV.Controls.Add(this.Splitter_LIV);
            this.PanelFill_LIV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFill_LIV.Location = new System.Drawing.Point(438, 200);
            this.PanelFill_LIV.Name = "PanelFill_LIV";
            this.PanelFill_LIV.Size = new System.Drawing.Size(466, 261);
            this.PanelFill_LIV.TabIndex = 3;
            // 
            // GroupBoxOutput_LIV
            // 
            this.GroupBoxOutput_LIV.Controls.Add(this.DataGridViewOutput_LIV);
            this.GroupBoxOutput_LIV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxOutput_LIV.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxOutput_LIV.Location = new System.Drawing.Point(3, 0);
            this.GroupBoxOutput_LIV.Name = "GroupBoxOutput_LIV";
            this.GroupBoxOutput_LIV.Size = new System.Drawing.Size(463, 261);
            this.GroupBoxOutput_LIV.TabIndex = 1;
            this.GroupBoxOutput_LIV.TabStop = false;
            this.GroupBoxOutput_LIV.Text = "Вывод";
            // 
            // DataGridViewOutput_LIV
            // 
            this.DataGridViewOutput_LIV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewOutput_LIV.ColumnHeadersVisible = false;
            this.DataGridViewOutput_LIV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewOutput_LIV.Location = new System.Drawing.Point(3, 22);
            this.DataGridViewOutput_LIV.Name = "DataGridViewOutput_LIV";
            this.DataGridViewOutput_LIV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewOutput_LIV.Size = new System.Drawing.Size(457, 236);
            this.DataGridViewOutput_LIV.TabIndex = 0;
            // 
            // Splitter_LIV
            // 
            this.Splitter_LIV.Location = new System.Drawing.Point(0, 0);
            this.Splitter_LIV.Name = "Splitter_LIV";
            this.Splitter_LIV.Size = new System.Drawing.Size(3, 261);
            this.Splitter_LIV.TabIndex = 0;
            this.Splitter_LIV.TabStop = false;
            // 
            // OpenFileDialog_LIV
            // 
            this.OpenFileDialog_LIV.FileName = "openFileDialog1";
            // 
            // ToolTip_LIV
            // 
            this.ToolTip_LIV.IsBalloon = true;
            this.ToolTip_LIV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 461);
            this.Controls.Add(this.PanelFill_LIV);
            this.Controls.Add(this.PanelLeft_LIV);
            this.Controls.Add(this.PanelTask_LIV);
            this.Controls.Add(this.PanelTop_LIV);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(920, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 10 | Лебедев И.В.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelTop_LIV.ResumeLayout(false);
            this.PanelTask_LIV.ResumeLayout(false);
            this.GroupBoxTask_LIV.ResumeLayout(false);
            this.GroupBoxTask_LIV.PerformLayout();
            this.PanelLeft_LIV.ResumeLayout(false);
            this.GroupBoxInput_LIV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInput_LIV)).EndInit();
            this.PanelFill_LIV.ResumeLayout(false);
            this.GroupBoxOutput_LIV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOutput_LIV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop_LIV;
        private System.Windows.Forms.Panel PanelTask_LIV;
        private System.Windows.Forms.GroupBox GroupBoxTask_LIV;
        private System.Windows.Forms.Panel PanelLeft_LIV;
        private System.Windows.Forms.GroupBox GroupBoxInput_LIV;
        private System.Windows.Forms.DataGridView DataGridViewInput_LIV;
        private System.Windows.Forms.Panel PanelFill_LIV;
        private System.Windows.Forms.GroupBox GroupBoxOutput_LIV;
        private System.Windows.Forms.DataGridView DataGridViewOutput_LIV;
        private System.Windows.Forms.Splitter Splitter_LIV;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_LIV;
        private System.Windows.Forms.ToolTip ToolTip_LIV;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog_LIV;
        private System.Windows.Forms.Button ButtonInfo_LIV;
        private System.Windows.Forms.Button ButtonSave_LIV;
        private System.Windows.Forms.Button ButtonDone_LIV;
        private System.Windows.Forms.Button ButtonOpen_LIV;
        private System.Windows.Forms.TextBox TextBoxTask_LIV;
    }
}

