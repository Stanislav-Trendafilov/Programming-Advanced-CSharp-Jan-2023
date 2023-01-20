using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> dic = new Dictionary<int,int>();
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num=int.Parse(Console.ReadLine());
                if(!dic.ContainsKey(num))
                {
                    dic[num] = 0; 
                }
                dic[num] += 1;
            }
            foreach (var item in dic)
            {
                if(item.Value%2==0)
                { Console.WriteLine(item.Key); }
            }
        }
    }
}
