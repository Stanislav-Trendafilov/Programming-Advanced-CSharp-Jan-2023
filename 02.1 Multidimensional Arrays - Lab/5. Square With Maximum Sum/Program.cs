using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowAndCol = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowAndCol[0];
            int cols = rowAndCol[1];
            int[,] biggestSum = new int[2, 2];
            int[,] numbers = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] rowsData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    numbers[row, col] = rowsData[col];
                }
            }
            int suma = 0;
            int MaxSum = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    suma = 0;
                    if (col + 1 < cols && row + 1 < rows)
                    { 
                        suma += numbers[row, col] + numbers[row, col + 1] + numbers[row + 1, col] + numbers[row + 1, col + 1];
                        if (suma > MaxSum)
                        {
                            MaxSum = suma;
                            biggestSum[0, 0] = numbers[row, col];
                            biggestSum[0, 1] = numbers[row, col + 1];
                            biggestSum[1, 0] = numbers[row + 1, col];
                            biggestSum[1, 1] = numbers[row + 1, col + 1];
                        }
                    }
                                
                }
            }
            PrintMatrix(biggestSum);
            Console.WriteLine(MaxSum);
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write($"{matrix[row, cols]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
