using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LebedevIV.Sprint6.Task7.V10.Lib;
using System.IO;

namespace Tyuiu.LebedevIV.Sprint6.Task7.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            OpenFileDialog_LIV.Filter = "Значения, разделененые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            SaveFileDialog_LIV.Filter = "Значения, разделененые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int colums;
        static string openFilePath;
        DataService ds = new DataService();

        public int[,] LoadFromFileData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_m = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_m[j]);
                }
            }
            return arrayValues;
        }

        private void ButtonOpen_LIV_Click(object sender, EventArgs e)
        {
            OpenFileDialog_LIV.ShowDialog();
            openFilePath = OpenFileDialog_LIV.FileName;

            int[,] arrayValues = new int[rows, colums];
            arrayValues = LoadFromFileData(openFilePath);

            DataGridViewInput_LIV.ColumnCount = colums;
            DataGridViewInput_LIV.RowCount = rows;
            DataGridViewOutput_LIV.ColumnCount = colums;
            DataGridViewOutput_LIV.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                DataGridViewInput_LIV.Columns[i].Width = 50;
                DataGridViewOutput_LIV.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    DataGridViewInput_LIV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            ButtonDone_LIV.Enabled = true;
        }

        private void ButtonDone_LIV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    DataGridViewOutput_LIV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            ButtonSave_LIV.Enabled = true;
        }

        private void ButtonSave_LIV_Click(object sender, EventArgs e)
        {
            SaveFileDialog_LIV.FileName = "OutPutFileTask7V20.csv";
            SaveFileDialog_LIV.InitialDirectory = Directory.GetCurrentDirectory();
            SaveFileDialog_LIV.ShowDialog();

            string path = SaveFileDialog_LIV.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = DataGridViewOutput_LIV.RowCount;
            int colums = DataGridViewOutput_LIV.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (j != colums - 1)
                    {
                        str = str + DataGridViewOutput_LIV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + DataGridViewOutput_LIV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void ButtonOpen_LIV_MouseEnter(object sender, EventArgs e)
        {
            ToolTip_LIV.ToolTipTitle = "Открыть файл";
        }

        private void ButtonDone_LIV_MouseEnter(object sender, EventArgs e)
        {
            ToolTip_LIV.ToolTipTitle = "Выполнить";
        }

        private void ButtonSave_LIV_MouseEnter(object sender, EventArgs e)
        {
            ToolTip_LIV.ToolTipTitle = "Сохранить в файл";
        }

        private void ButtonInfo_LIV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
