using System;
using System.Linq;
using System.Numerics;
using System.Xml.Serialization;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][]jaggedArray = new long[rows][];
            //set value of array's elements
            for (int row = 0; row < rows; row++)
            {
                long[]rowInfo=Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();
                jaggedArray[row] = new long[rowInfo.Length];
                for (int col = 0; col < rowInfo.Length; col++)
                {
                    jaggedArray[row][col]= rowInfo[col];                 
                }
            }
            //first manipulation
            for (int row = 0; row < rows-1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row+1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }
                    for (int col = 0; col < jaggedArray[row+1].Length; col++)
                    {
                        jaggedArray[row+1][col] /= 2;
                    }
                }
            }

            string command=Console.ReadLine();
            while(command != "End")
            {
                string[]cmdArg=command
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries);
                int row1 = int.Parse(cmdArg[1]);
                int col1 = int.Parse(cmdArg[2]);
                long value = long.Parse(cmdArg[3]); 

                if (row1 >= 0 && row1 < jaggedArray.GetLength(0) && col1 >= 0 && col1 < jaggedArray[row1].Length) 
                {
                    if (cmdArg[0] == "Add")
                    {
                        jaggedArray[row1][col1] += value;
                    }
                    else if (cmdArg[0] == "Subtract")
                    {
                        jaggedArray[row1][col1] -= value;
                    }
                }
                command= Console.ReadLine();
            }
            PrintArray(jaggedArray);

        }
        static void PrintArray(long[][]matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
