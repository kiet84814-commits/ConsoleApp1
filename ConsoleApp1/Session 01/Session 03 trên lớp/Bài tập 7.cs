using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_03_trên_lớp
{
    internal class Bài_tập_7
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 7");
            Console.WriteLine(" Nhập số bắt đầu:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số kết thúc");
            int end = int.Parse(Console.ReadLine());
            for (int num = start; num <= end; num++)
            {
                int sum = 0;
                for (int j = 1; j < num; j++)
                {
                    if (num % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == num && num > 0)
                {
                    Console.WriteLine($"{num} là số hoàn hảo.");
                }

            }
        }
    }
