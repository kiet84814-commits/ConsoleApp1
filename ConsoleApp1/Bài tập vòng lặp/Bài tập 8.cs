using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập_vòng_lặp
{
    internal class Bài_tập_8
    {
        public static int DemNguyenAm(string s)
        {
            int count = 0;
            s = s.ToLower();
            string nguyenam = "aoeui";
            for (int i = 0; i < s.Length; i++)
            {
                if (nguyenam.Contains(s[i]))
                {
                    count++;
                }
            }
            return count;
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhập vào chuỗi n");
            string n = (Console.ReadLine());
            int result = DemNguyenAm(n);
            Console.WriteLine($"Kết quả là:{result}");
            {

            }
        }
    }
}

