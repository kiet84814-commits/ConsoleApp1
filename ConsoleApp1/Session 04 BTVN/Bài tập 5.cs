using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_04_BTVN
{
    internal class Bài_tập_5
    {
        public static string DaoNguocChuoi(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public static void Main48(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(" Nhập vào chuỗi cần đảo ngược:");
            string input = Console.ReadLine();
            Console.WriteLine($"chuỗi cần đảo ngược:{DaoNguocChuoi(input)}");

        }

        }
    }
