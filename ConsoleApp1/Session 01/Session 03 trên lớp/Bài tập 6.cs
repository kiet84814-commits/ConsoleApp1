using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_03_trên_lớp
{
    internal class Bài_tập_6
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 6");
            Console.WriteLine(" Nhập số dòng ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"1/{i}+");
                sum += 1.0 / i;
            }
            Console.WriteLine($"\nsum={sum}");
        }
    }


           
}
