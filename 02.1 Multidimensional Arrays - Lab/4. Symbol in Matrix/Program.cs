using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsAndCols = int.Parse(Console.ReadLine());
            string[,] matrix = new string[rowsAndCols, 1];
            string info = string.Empty;
            bool flag= false;
            for (int row = 0; row < rowsAndCols; row++)
            {
                string rowsData = Console.ReadLine();
                for (int col = 0; col < 1; col++)
                {
                    matrix[row,col]=rowsData;
                }
            }
            char Symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < rowsAndCols; row++)
            {
                string rowsData = matrix[row,0];
                for (int col = 0; col < rowsAndCols; col++)
                {
                    if (rowsData[col] == Symbol)
                    {
                        info = $"({row}, {col})";
                        flag = true;
                        break;
                    }
                }
                if (flag)
                { break; }
            }
            if (flag)
            { Console.WriteLine(info); }
            else
            {
                Console.WriteLine($"{Symbol} does not occur in the matrix");
            }    
        }
       
    }
}
