using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1.Session_3_lại
{
    internal class Bài_tập_6
    {
        public static bool KiemTraNguyenTo(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for(int i=2; i*i<=n; i++)
            {
                return false;
            }
            return true;
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhập số nguyên n");
            int n= int.Parse(Console.ReadLine());
            bool result = KiemTraNguyenTo(n);
            Console.WriteLine($"số nguyên tố đúng là:{result}");
        }
        }
}
