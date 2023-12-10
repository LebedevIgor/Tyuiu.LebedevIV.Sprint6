using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LebedevIV.Sprint6.Task5.V1.Lib;

namespace Tyuiu.LebedevIV.Sprint6.Task5.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\Igor\source\repos\Tyuiu.LebedevIV.Sprint6\Tyuiu.LebedevIV.Sprint6.Task5.V1\bin\Debug\InPutFileTask5V1.txt";

        private void buttonDone_LIV_Click(object sender, EventArgs e)
        {
            dataGridViewResult_LIV.ColumnCount = 2;
            dataGridViewResult_LIV.Columns[0].Width = 20;
            dataGridViewResult_LIV.Columns[1].Width = 80;

            this.chartResult_LIV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_LIV.ChartAreas[0].AxisY.Title = "Ось Y";
            chartResult_LIV.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_LIV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_LIV.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_LIV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_LIV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-3 Лебедев Игорь Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
