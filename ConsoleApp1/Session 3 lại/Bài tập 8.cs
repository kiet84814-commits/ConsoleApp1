using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_3_lại
{
    internal class Bài_tập_8
    {
        public static int DemNguyenAm(string s)
        {
            string lowerS = s.ToLower();
            return lowerS.Count(c => "aouei".Contains(c));
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập chuỗi");
            string c= (Console.ReadLine());
            int result = DemNguyenAm(c);
            Console.WriteLine($"Kết quả là:{result}");
        }




        }
}
