using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập_vòng_lặp
{
    internal class Bài_tập_9
    {
        public static double TinhLuyThua(double x, int y)
        {
            double ketqua = 1;
            for(int i=1; i<=y; i++)
            {
                ketqua *= x;
            }
            return ketqua;
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập y");
            int y= int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập x");
            double x= double.Parse(Console.ReadLine());
            double result = TinhLuyThua(x, y);
            Console.WriteLine($"Kết quả là:{result}");
        }
        }
}
