using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowAndCol = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowAndCol[0];
            int cols = rowAndCol[1];
            int suma = 0;
            int[,] numbers = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] rowsData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    numbers[row, col] = rowsData[col];
                 
                }
            }
            for (int col = 0; col < cols; col++)
            {
                suma = 0;
                for (int row = 0; row < rows; row++)
                {
                    suma += numbers[row, col];
                }
                Console.WriteLine(suma);
            }
        }
    }
}
