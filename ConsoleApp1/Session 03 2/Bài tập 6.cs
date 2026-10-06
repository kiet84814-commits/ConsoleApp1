using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_03_2
{
    internal class Bài_tập_6
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số lượng phần tử n: ");
            int n= int.Parse(Console.ReadLine());
            double sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;

                if (i == 1)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write($" +1/{i}");
                }
               
            }
            Console.WriteLine($"tổng là:{sum}");
        }

        }
}
