using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LebedevIV.Sprint6.Task1.V12.Lib;

namespace Tyuiu.LebedevIV.Sprint6.Task1.V12
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
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_LIV.Text = "";
                textBoxResult_LIV.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_LIV.AppendText("|     X    |   f(x)   |" + Environment.NewLine);
                textBoxResult_LIV.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,6:d}    |  {1, 5:f2}   | ", startStep, valueArray[i]);
                    textBoxResult_LIV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_LIV.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void buttonHelp_LIV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-3 Лебедев Игорь Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
