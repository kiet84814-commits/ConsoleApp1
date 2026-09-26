using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_04_BTVN
{
    internal class Bài_tập_5_lại
    {
        public static string DaoNguocChuoi(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public static void Main47(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào một chuỗi");
            string input = Console.ReadLine();
            String result = DaoNguocChuoi(input);
            Console.WriteLine($"{result}");
        }
        }
    }
