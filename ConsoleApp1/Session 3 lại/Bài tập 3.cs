using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp1.Session_3_lại
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
            Console.WriteLine("Nhập giá trị của a");
            Console.WriteLine("Nhập giá trị của b");
            Console.WriteLine("Nhập giá trị của c");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int result = TimMax(a, b, c);
            Console.WriteLine($"Số lớn nhất là:{result}");
        }
        }
    
    }

