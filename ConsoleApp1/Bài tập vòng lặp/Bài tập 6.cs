using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập_vòng_lặp
{
    internal class Bài_tập_6
    {
        public static bool KiemTraNguyenTo(int n)
        {
            if (n < 2)
            {
                return false;
                
            }
            for(int i=2; i<n; i++)
            {
                n %= i;
                return false;

            }
            return true;
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào n");
            int n= int.Parse(Console.ReadLine());
            bool result = KiemTraNguyenTo(n);
            Console.WriteLine($"kết quả là:{result}");


        }
        }
}
