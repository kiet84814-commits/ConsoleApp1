using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_04_BTVN
{
    internal class Bài_tập_1
    {
        public static int TinhTong(int a, int b)
        {
            return a + b;
        }
        public static void Main39(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(" Nhập số nguyên a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhập số nguyên b");
            int b = int.Parse(Console.ReadLine());
            int sum = TinhTong(a, b);
            Console.WriteLine($"Tổng của {a} và {b} là: {sum}");
           
        }
    }
}
