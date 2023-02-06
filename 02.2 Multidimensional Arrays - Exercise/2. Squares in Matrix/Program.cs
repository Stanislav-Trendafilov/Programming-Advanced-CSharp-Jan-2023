using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]rowsAndCols=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,]matrix = new char[rowsAndCols[0], rowsAndCols[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowInfo = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowInfo[col];
                }
            }

            int numberOfSameSquares = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                   
                        if (matrix[row, col] == matrix[row, col + 1] 
                        && matrix[row, col] == matrix[row + 1, col] 
                        && matrix[row, col] == matrix[row+1,col+1]) 
                        { 
                            numberOfSameSquares++;
                        }
                    
                }
            }
            Console.WriteLine(numberOfSameSquares);
        }
    }
}
