using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsAndCols = int.Parse(Console.ReadLine());
            int[,]numbers=new int[rowsAndCols, rowsAndCols];
            List<int>primary=new List<int>();
            for (int row = 0; row < rowsAndCols; row++)
            {
                int[] rowsData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < rowsAndCols; col++)
                {
                    numbers[row, col] = rowsData[col];
                    if(row==col) { primary.Add(numbers[row, col]); }
                }
            }
            Console.WriteLine(primary.Sum());
        }
    }
}
