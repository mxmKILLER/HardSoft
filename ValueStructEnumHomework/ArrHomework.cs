using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueStructEnumHomework
{
    public class ArrHomework
    {
        int[,] array = new int[3,4];

        public ArrHomework()
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetUpperBound(0)+1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    array[i, j] = rnd.Next(0, 128);
                }
            }
        }

        public void ShowArray()
        {
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void SerchForMaxInARow()
        {
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                int MaxInARow = 0;
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    if (array[i, j] > MaxInARow)
                    {
                        MaxInARow = array[i, j];
                    }
                }
                Console.WriteLine($"Max element in a {i} row is {MaxInARow}");
            }
        }

        public void SerchForMinInAColumn()
        {
            for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
            {
                int iMin = 0;
                int jMin = j;
                for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
                {
                    if (array[i, j] < array[iMin, jMin])
                    {
                        iMin = i;                       
                    }
                }
                Console.WriteLine($"Max element in a {j} column is {array[iMin, jMin]}");
            }
        }
    }
}
