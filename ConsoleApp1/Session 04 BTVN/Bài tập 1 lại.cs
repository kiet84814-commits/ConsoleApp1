using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_04_BTVN
{
    internal class Bài_tập_1_lại
    {
        public static int TinhTong32(int a, int b)
        {
            return a + b;

        }
        public static void Main38(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên a");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số nguyên b");
            int b = int.Parse(Console.ReadLine());
            

        }
    }
}
