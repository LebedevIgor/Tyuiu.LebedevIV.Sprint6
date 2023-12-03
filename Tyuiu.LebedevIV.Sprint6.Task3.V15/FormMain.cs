using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LebedevIV.Sprint6.Task3.V15.Lib;

namespace Tyuiu.LebedevIV.Sprint6.Task3.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] matrix = {
                { 33, 28, 31, 19, 4 },
                { 1, 32, -3, -17, -12 },
                { 24, -19, 26, 31, -3 },
                { 30, -16, 29, 28, 8 },
                { 30, 5, 11, 7, 32 }
            };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            dataGridViewCondition_LIV.ColumnCount = columns;
            dataGridViewCondition_LIV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewCondition_LIV.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                dataGridViewCondition_LIV.Rows[i].Height = 25;
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewCondition_LIV.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonDone_LIV_Click(object sender, EventArgs e)
        {
            textBoxResult_LIV.Text = "Результат в таблице";

            int[,] array = ds.Calculate(matrix);
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            dataGridViewCondition_LIV.ColumnCount = columns;
            dataGridViewCondition_LIV.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewCondition_LIV.Rows[i].Cells[j].Value = array[i, j].ToString();
                }
            }
        }

        private void buttonHelp_LIV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-23-3 Лебедев Игорь Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
