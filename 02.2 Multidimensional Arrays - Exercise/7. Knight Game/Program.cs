using System;
using System.Security.Cryptography;

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size=int.Parse(Console.ReadLine());
            if(size < 3 ) 
            {
                Console.WriteLine(0);
                return;
            }
            char[,]board=new char[size,size];
            for (int row = 0; row < size; row++)
            {
                string chars=Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    board[row,col] = chars[col];
                }
            }
            int br = 1;
            int maxBr = 0;
            int removedKnights = 0;
            int maxRow = 0;
            int maxCol = 0;
            while(br!=0) 
            {
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        br = 0;
                        if (board[row,col]=='K')
                        {
                            if (row-2>=0&&col+1<size)
                            {
                                if (board[row - 2, col + 1] == 'K')
                                {
                                    br++;
                                }
                            }
                            if (row - 2 >= 0 && col - 1 >= 0)
                            {
                                if (board[row - 2, col - 1] == 'K')
                                {
                                    br++; 
                                }
                            }
                            if (row + 2 <size && col +1 < size)
                            {
                                if (board[row + 2, col + 1] == 'K')
                                {
                                    br++;
                                }
                            }
                            if (row + 2 < size && col - 1 >= 0)
                            {
                                if(board[row + 2, col - 1] == 'K')
                                { br++; }
                            }
                            if (row + 1 < size && col +2  < size)
                            {
                                if (board[row + 1, col + 2] == 'K')
                                { br++; }
                            }
                            if (row - 1 >= 0 && col+2 <size)
                            {
                                if (board[row - 1, col + 2] == 'K')
                                {
                                    br++;
                                }
                            }
                            if (row + 1 <size && col -2  >=0)
                            {
                                if (board[row + 1, col - 2] == 'K')
                                {
                                    br++;
                                }
                            }
                            if (row - 1 >=0 && col - 2 >= 0)
                            {
                                if (board[row - 1, col - 2] == 'K')
                                { br++; }
                            }
                            if(br>maxBr)
                            {
                                maxBr = br;
                                maxCol= col;
                                maxRow= row;
                            }
                        }

                    }
                }
                if(maxBr!=0)
                {
                    removedKnights ++;
                    maxBr = 0;
                    board[maxRow, maxCol] = '0';
                    br = 1;
                }
            }
            Console.WriteLine(removedKnights);
        }
    }
}
