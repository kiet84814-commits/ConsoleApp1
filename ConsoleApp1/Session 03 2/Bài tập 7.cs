using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp1.Session_03_2
{
    internal class Bài_tập_7
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập vào khoảng bắt đầu ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào khoảng kết thúc");
            int end = int.Parse(Console.ReadLine());
            
            for(int i=start;i<=end;i++)
            {
                if (i <= 0) continue;
                 
                    int sum = 0;
                
                for(int j=1;j<i;j++)
                {
                    if(i % j == 0)
                    {
                        sum += j;
                    }    
                }
                if (sum == i)
                {
                    Console.WriteLine($"số đó là số nguyên tố là:{i}");
                }
            }    
           
        }
        }
}
