using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_03_trên_lớp
{
    internal class Bài_tập_2
    {
        public static void Main16(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 2");
            double sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Nhập số thứ {i}:");
                double num = double .Parse( Console.ReadLine() );
                sum+= num;
            }
            double average = sum/10;
            Console.WriteLine($"Trung bình cộng là:{average}");
            Console.Write($"Tổng 10 số đã nhập là:{ sum}");



        }
    }
}
