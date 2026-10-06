using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập_vòng_lặp
{
    internal class Bài_tập_5
    {
        public static string DaoNguocChuoi(string input)
        {
            char[]kiet= input.ToCharArray();
            Array.Reverse(kiet);
            
            return new string(kiet);
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào chuỗi ký tự");
            string kiet= (Console.ReadLine());
            string result = DaoNguocChuoi(kiet);
            Console.WriteLine($"Kết quả là:{result}");
        }


        }
}
