using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_03_trên_lớp
{
    internal class Bài_tập_1
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 1");
           Console.WriteLine("Nhập số dòng");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
