using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1.Session_04_BTVN
{
    internal class Bài_tập_3_lại
    {
        public static int TimMax(int a, int b, int c)
        {
            int Max = a;
            if (b > Max)
            {
                Max = b;
            }
            if (c > b)
            {
                Max = c;
            }
            return Max;
        }
        public static void Main43(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên a");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số nguyên b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số nguyên c");
            int c = int.Parse(Console.ReadLine());
            int result = TimMax( a,  b,  c);
            Console.WriteLine($"số lớn nhất là :{result}");


        }

    }

    }

