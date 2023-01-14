 using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]rowAndCol=Console.ReadLine().Split(", ").Select(int.Parse ).ToArray();
            int rows =rowAndCol[0];
            int cols = rowAndCol[1];
            int suma = 0;
            int[,] numbers =new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] rowsData=Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col <cols;  col++)
                {
                    numbers[row, col] = rowsData[col];
                    suma += numbers[row, col];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(suma);

        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write($"{matrix[row,cols]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
