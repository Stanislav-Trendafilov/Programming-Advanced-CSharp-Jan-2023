using System;
using System.Linq;

namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            string snake=Console.ReadLine();

            char[,]snakeMoves=new char[rowsAndCols[0],rowsAndCols[1]];
            int i = 0;
            for (int row = 0; row < snakeMoves.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    
                    for (int col = 0; col < snakeMoves.GetLength(1); col++)
                    {
                        
                        snakeMoves[row,col]=snake[i];
                        i++;
                        if(i==snake.Length)
                        {
                            i = 0;
                        }
                    }
                }
                else
                {
                    for (int col = snakeMoves.GetLength(1) - 1; col >= 0; col--)
                    {
                        snakeMoves[row, col] = snake[i];
                        i++;
                        if (i == snake.Length)
                        {
                            i = 0;
                        }
                    }
                }             
            }
            PrintMatrix(snakeMoves);
        }
        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
