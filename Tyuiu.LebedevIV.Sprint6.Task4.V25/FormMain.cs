﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LebedevIV.Sprint6.Task4.V25.Lib;
using System.IO;


namespace Tyuiu.LebedevIV.Sprint6.Task4.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_LIV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_LIV.Text);
                int stopStep = Convert.ToInt32(textBoxEndStep_LIV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartResult_LIV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_LIV.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_LIV.Text = "";

                chartResult_LIV.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartResult_LIV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_LIV.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-23-3 Лебедев Игорь Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonSave_LIV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V11.txt";
                File.WriteAllText(path, textBoxResult_LIV.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();

                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
