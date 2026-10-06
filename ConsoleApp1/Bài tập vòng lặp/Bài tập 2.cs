using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập_vòng_lặp
{
    internal class Bài_tập_2
    {
        public static bool KiemTraChan(int n)
        {
            if(n%2==0)
            {
                return true;
            }    
            else
            {
                return false;
            }    
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên n");
            int n=int.Parse(Console.ReadLine());
            bool result = KiemTraChan(n);
            Console.WriteLine($"Kết quả là:{result}");
        }
        }
}
