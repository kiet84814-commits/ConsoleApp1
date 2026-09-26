using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_04_BTVN
{
    internal class Bài_tập_2_lại
    {
        public static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }
        public static void Main41(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên n");
            int n = int.Parse(Console.ReadLine());
            if (KiemTraChan(n))
            {
                Console.WriteLine("n là số chẵn");
            }
            else
            {
                Console.WriteLine("n là số lẻ");
            } 
                
        }
        }
}

