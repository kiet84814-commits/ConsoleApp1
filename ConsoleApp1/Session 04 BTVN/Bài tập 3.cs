using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_04_BTVN
{
    internal class Bài_tập_3
    {
        public static int TimMax(int a, int b, int c)
        {
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            return max;
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số nguyên b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số nguyên c");
            int c = int.Parse(Console.ReadLine());
            int result = TimMax(a, b, c);
            Console.WriteLine($"Số lớn nhất trong 3 số là: {result}");
        }    
        }
    }

