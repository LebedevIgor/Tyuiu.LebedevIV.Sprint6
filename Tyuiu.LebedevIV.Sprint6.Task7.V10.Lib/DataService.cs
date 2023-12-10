using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.LebedevIV.Sprint6.Task7.V10.Lib
{
    public class DataService : ISprint6Task7V10
    {
        public int[,] GetMatrix(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] line = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = line.Length;
            int colums = line[0].Split(';').Length;
            int[,] matrix = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] values = line[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    int value = Convert.ToInt32(values[j]);
                    if (i == 4 && value >= 5 && value <= 10)
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = value;
                    }
                }
            }

            return matrix;
        }
    }
}
