using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.LebedevIV.Sprint6.Task3.V15.Lib
{
    public class DataService : ISprint6Task3V15
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] tempArray = new int[rows, 2];
            for (int i = 0; i < rows; i++)
            {
                tempArray[i, 0] = matrix[i, 2]; 
                tempArray[i, 1] = i; 
            }
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (tempArray[j, 0] > tempArray[j + 1, 0])
                    {
                        int temp = tempArray[j, 0];
                        tempArray[j, 0] = tempArray[j + 1, 0];
                        tempArray[j + 1, 0] = temp;

                        temp = tempArray[j, 1];
                        tempArray[j, 1] = tempArray[j + 1, 1];
                        tempArray[j + 1, 1] = temp;
                    }
                }
            }

            int[,] sortedMatrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                int index = tempArray[i, 1];
                for (int j = 0; j < cols; j++)
                {
                    sortedMatrix[i, j] = matrix[index, j];
                }
            }

            return sortedMatrix;
        }
    }
}
