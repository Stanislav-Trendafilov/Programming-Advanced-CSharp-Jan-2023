using System;
using System.Data;
using System.Globalization;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
              // 3
              // 1 2 3
              // 4 5 6 7
              // 8 9 10
            int rows=int.Parse(Console.ReadLine());
            int[][] numbers = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                int[]rowData=Console.ReadLine().Split().Select(int.Parse).ToArray();
                numbers[row] =new int[rowData.Length];  
                for (int col = 0; col < rowData.Length; col++)
                {
                    numbers[row][col] = rowData[col];
                }
            }
            string command=Console.ReadLine();
            while (command != "END")
            {
                string[] cmdArg = command.Split().ToArray();
                string cmdType = cmdArg[0];
                int row = int.Parse(cmdArg[1]);
                int col = int.Parse(cmdArg[2]);
                int num = int.Parse(cmdArg[3]);

                if (row < numbers.Length && row >= 0 && col<numbers[row].Length&&col>=0)
                { 
                    if (cmdType == "Add")
                    {
                        numbers[row][col]+=num;
                    }
                    else
                    {
                        numbers[row][col] -= num;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
                command = Console.ReadLine();
            }
            for (int row = 0; row < rows; row++)
            {               
                for (int col = 0; col < numbers[row].Length; col++)
                {
                    Console.Write($"{numbers[row][col]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
