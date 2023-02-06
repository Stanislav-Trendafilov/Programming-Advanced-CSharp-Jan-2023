using System;
using System.Linq;

namespace _9._Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            string[,]matrix= new string[n,n];
            string[]commands=Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries);
            int minerX = 0;
            int minerY = 0;
            int coalCount = 0;

            for (int i = 0; i < n; i++)
            {
                string[]rowInfo=Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rowInfo[j];
                    if (matrix[i, j] == "s")
                    {
                        minerX = i;
                        minerY = j;
                    }
                    else if (matrix[i, j] =="c")
                    {
                        coalCount++;
                    }
                }
            }

            int minerCoal = 0;
            bool finished = false;
            for (int i = 0; i < commands.Length; i++)
            {
                string currCommand = commands[i];
                if(currCommand== "up")
                {
                    if (minerX - 1 >= 0)
                    {
                        if (matrix[minerX-1,minerY]=="e") 
                        {
                            Console.WriteLine($"Game over! ({minerX-1}, {minerY})");
                            finished= true;
                            break;
                        }
                        else if (matrix[minerX-1,minerY]=="c")
                        {
                            minerCoal++;
                            if(minerCoal==coalCount)
                            {
                                Console.WriteLine($"You collected all coals! ({minerX - 1}, {minerY})");
                                finished = true;
                                break;
                            }                        
                        }
                        matrix[minerX - 1, minerY] = "s";
                        minerX=minerX-1;
                    }
                }
                else if (currCommand == "down")
                {
                    if (minerX + 1 <matrix.GetLength(0))
                    {
                        if (matrix[minerX + 1, minerY] == "e")
                        {
                            Console.WriteLine($"Game over! ({minerX + 1}, {minerY})");
                            finished = true;
                            break;
                        }
                        else if (matrix[minerX + 1, minerY] == "c")
                        {
                            minerCoal++;
                            if (minerCoal == coalCount)
                            {
                                Console.WriteLine($"You collected all coals! ({minerX + 1}, {minerY})");
                                finished = true;
                                break;
                            }
                        }
                        matrix[minerX + 1, minerY] = "s";
                        minerX = minerX + 1;
                    }
                }
                else if (currCommand == "right")
                {
                    if (minerY+1<matrix.GetLength(1))
                    {
                        if (matrix[minerX, minerY+1] == "e")
                        {
                            Console.WriteLine($"Game over! ({minerX}, {minerY+1})");
                            finished = true;
                            break;
                        }
                        else if (matrix[minerX, minerY+1] == "c")
                        {
                            minerCoal++;
                            if (minerCoal == coalCount)
                            {
                                Console.WriteLine($"You collected all coals! ({minerX}, {minerY+1})");
                                finished = true;
                                break;
                            }
                        }
                        matrix[minerX, minerY+1] = "s";
                        minerY = minerY + 1;
                    }
                }
                else if (currCommand == "left")
                {
                    if (minerY - 1 >=0)
                    {
                        if (matrix[minerX, minerY - 1] == "e")
                        {
                            Console.WriteLine($"Game over! ({minerX}, {minerY - 1})");
                            finished = true;
                            break;
                        }
                        else if (matrix[minerX, minerY - 1] == "c")
                        {
                            minerCoal++;
                            if (minerCoal == coalCount)
                            {
                                Console.WriteLine($"You collected all coals! ({minerX}, {minerY - 1})");
                                finished = true;
                                break;
                            }
                        }
                        matrix[minerX, minerY - 1] = "s";
                        minerY = minerY - 1;
                    }
                }
            }
            if(!finished)
            {
                Console.WriteLine($"{coalCount-minerCoal} coals left. ({minerX}, {minerY})");
            }
        }
    }
}
