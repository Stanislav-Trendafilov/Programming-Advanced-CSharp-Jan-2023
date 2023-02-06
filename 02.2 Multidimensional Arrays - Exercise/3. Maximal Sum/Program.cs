using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndCols[0], rowsAndCols[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowInfo[col];
                }
            }
            int maxSum = 0;
            //Judge не хваща но maxSum=int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int suma = 0;
                    suma += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + 
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]+
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if(suma>maxSum) 
                    { 
                        maxSum= suma;
                        maxSumRow= row;
                        maxSumCol = col;
                    }

                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int row = maxSumRow; row < maxSumRow+3; row++)
            {
                for (int col = maxSumCol; col < maxSumCol+3; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
