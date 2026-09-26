using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_03_trên_lớp
{
    internal class Bài_tập_52
    {
        public static void Main20(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 5");
            Console.WriteLine("Nhập số dòng");
            int count = 1;
            int n = int .Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                {
                    for (int k = 1; k <= n-i; k++)
                    {
                        Console.Write(" ");
                    }    
                    for (int j = 1; j <= i; j++) {
                        Console.Write(count++ + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
