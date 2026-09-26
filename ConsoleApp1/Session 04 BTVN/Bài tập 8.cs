using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_04_BTVN
{
    internal class Bài_tập_8
    {
        public static int DemNguyenAm(string s)
        {
            int count = 0;
            string vowels = "aoeuiAEOUI";
            foreach (char c in s)
            {
                count = count + 1;
            }
            return count;
        }
        public static void Main52(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(" Nhập vào chuỗi ký tự ");
            string input = Console.ReadLine();
            Console.WriteLine($"");
                }
        }
}
