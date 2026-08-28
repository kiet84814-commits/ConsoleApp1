using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01
{
    public class Bài_tập_2
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 2");
            Console.Write("Nhập bán kính: ");
            double radius = double.Parse(Console.ReadLine());
            double surface = 4*Math.PI * radius * radius;
            double volume = (4.0/3.0) * Math.PI * radius * radius * radius;
            Console.WriteLine($"Diện tích: {surface}");
            Console.WriteLine($"Thể tích: {volume}");

        }
    }
}
