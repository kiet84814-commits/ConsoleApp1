using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_3_lại
{
    internal class Bài_tập_4
    {
        public static long TinhGiaiThua(int n)
        {
            long ketqua = 1;
            for (int i = 1; i <= n; i++)
            {
                ketqua *=i;
            }
            return ketqua;
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên n");
            int n= int.Parse(Console.ReadLine());
            long ketqua = TinhGiaiThua(n);
            Console.WriteLine($"Kết quả là:{ketqua}");
        }
        }
}
