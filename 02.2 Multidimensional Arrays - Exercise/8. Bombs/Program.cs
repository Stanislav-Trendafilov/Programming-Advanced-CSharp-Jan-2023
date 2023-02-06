using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _8._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int[]rowInfo=Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j= 0; j < n; j++)
                {
                    matrix[i, j] = rowInfo[j];
                }
            }

            string[]bombs=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < bombs.Length; i++)
            {
                int[] bombsCordinates = bombs[i]
                    .Split(",")
                    .Select(int.Parse)
                    .ToArray();
                matrix = Explode(bombsCordinates[0], bombsCordinates[1],matrix);
            }
            int suma = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] > 0)
                    { 
                        suma += matrix[i, j];
                        count++;
                    }
                }
            }
            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {suma}");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static int[,] Explode(int x,int y, int[,]arr)
        {
            int bombValue = arr[x, y];
            if (bombValue > 0)
            {
                arr[x, y] = 0;
                if (!(x - 1 < 0))
                {
                    if (arr[x - 1, y] > 0)
                    {
                        arr[x - 1, y] -= bombValue;
                    }
                }
                if (!(x - 1 < 0 || y - 1 < 0))
                {
                    if (arr[x - 1, y - 1] > 0)
                    {
                        arr[x - 1, y - 1] -= bombValue;
                    }
                }
                if (!(x - 1 < 0 || y + 1 > arr.GetLength(1) - 1))
                {
                    if (arr[x - 1, y + 1] > 0)
                    {
                        arr[x - 1, y + 1] -= bombValue;
                    }
                }
                if (!(y + 1 > arr.GetLength(1) - 1))
                {
                    if (arr[x, y + 1] > 0)
                    {
                        arr[x, y + 1] -= bombValue;
                    }
                }
                if (!(y - 1 < 0))
                {
                    if (arr[x, y - 1] > 0)
                    {
                        arr[x, y - 1] -= bombValue;
                    }
                }
                if (!(x + 1 > arr.GetLength(0) - 1))
                {
                    if (arr[x + 1, y] > 0)
                    {
                        arr[x + 1, y] -= bombValue;
                    }
                }
                if (!(x + 1 > arr.GetLength(0) - 1 || y - 1 < 0))
                {
                    if (arr[x + 1, y - 1] > 0)
                    {
                        arr[x + 1, y - 1] -= bombValue;
                    }
                }
                if (!(x + 1 > arr.GetLength(0) - 1 || y + 1 > arr.GetLength(1) - 1))
                {
                    if (arr[x + 1, y + 1] > 0)
                    {
                        arr[x + 1, y + 1] -= bombValue;
                    }
                }
            }
            return arr;
        }
    }
}
