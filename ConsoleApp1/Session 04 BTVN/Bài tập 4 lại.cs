using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_04_BTVN
{
    internal class Bài_tập_4_lại
    {
        public static long TinhGiaiThua(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++) 
            {
                result *= i;
            }
            return result;
        }
        public static void Main45(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(" Nhập số nguyên n");
            int n = int.Parse(Console.ReadLine());
            long result = TinhGiaiThua(n);
            Console.WriteLine($"Kết quả giai thừa là : {result}");
        }
        }
}
