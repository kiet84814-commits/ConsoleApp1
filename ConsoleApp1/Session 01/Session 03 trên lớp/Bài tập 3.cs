using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_03_trên_lớp
{
    internal class Bài_tập_3
    {
        public static void Main17(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 2");
            Console.WriteLine("Nhập vào một số nguyên");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            Console.WriteLine($" {n} x {i} = {n} * {i} ");
            }
        }
    }

