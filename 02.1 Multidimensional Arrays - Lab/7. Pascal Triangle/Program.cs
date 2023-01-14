using System;

namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows=int.Parse(Console.ReadLine());
            long[][] arr=new long[rows][];
            arr[0] = new long[1];
            arr[0][0] = 1;
            Console.WriteLine("1");

            for (int row= 1; row < rows; row++)
            {
                arr[row]=new long[row+1];
                arr[row][0] = 1;
                arr[row][row] = 1;
                for (int col = 1; col < row; col++)
                {
                    arr[row][col] = arr[row-1][col]+ arr[row - 1][col-1];
                }
                for (int cols = 0; cols < row+1; cols++)
                {
                    Console.Write($"{arr[row][cols]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
