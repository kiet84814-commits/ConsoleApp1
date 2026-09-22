using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_04_BTVN
{
    internal class Bài_tập_9
    {
        public static double TinhLuyThua(double x, double y)
        {
            double result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;

        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double x = 2;
            double y = 3;
            double output = TinhLuyThua(x, y);
            System.Console.WriteLine($"Input: x = {x}, y = {y} -> Output: {output}");
        }
    }
}





    