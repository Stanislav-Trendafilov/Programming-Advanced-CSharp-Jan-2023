using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,]matrix=new int[n,n];
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[]rowInfo=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = rowInfo[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(row==col)
                    { primaryDiagonalSum+= matrix[row,col];}
                    if(row==n-col-1)
                    {
                        secondaryDiagonalSum+= matrix[row,col];
                    }
                }
            }
            Console.WriteLine(Math.Abs(primaryDiagonalSum-secondaryDiagonalSum));

        }
    }
}
