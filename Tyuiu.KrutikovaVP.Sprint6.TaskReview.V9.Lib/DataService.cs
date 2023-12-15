using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KrutikovaVP.Sprint6.TaskReview.V9.Lib
{
    public class DataService
    {
        public int[,] GetMatrix(int n, int m, int n1, int n2)
        {
            Random rnd = new Random();
            int[,] array = new int[n, m];
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            if (columns % 2 == 0)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j = j + 2)
                    {
                        array[i, j] = rnd.Next(n1, n2 + 1);
                        array[i, j + 1] = array[i, j] * array[i, j];
                    }
                }
            }
            else
            {
                int columns2 = columns - 1;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns2; j = j + 2)
                    {
                        array[i, j] = rnd.Next(n1, n2 + 1);
                        array[i, j + 1] = array[i, j] * array[i, j];
                    }
                    array[i, columns - 1] = rnd.Next(n1, n2 + 1);
                }
            }
            return array;

        }
        public int resultGetMatrix(int[,] array, int c, int k, int l)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int mult = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    if ((i >= k && i <= l && j == c) && array[i, j] % 2 == 0)
                    {
                        mult *= array[i, j];
                    }

                }
            }
            return mult;
        }
    }
}
