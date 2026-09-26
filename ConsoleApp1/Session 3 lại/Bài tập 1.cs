using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_3_lại
{
    internal class Bài_tập_1
    {
        public static int TinhTong(int a, int b)
        {
            return a + b;
        }
        public static void Main38(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên a");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào số nguyên b");
            int b= int.Parse(Console.ReadLine());
            int result = TinhTong(a, b);
            Console.WriteLine($"Tổng của a và b là:{result}");
             

        }
        }
}
