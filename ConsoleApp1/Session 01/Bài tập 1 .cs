using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01
{
    public class Bài_tập_1
    {
        public static void Main22(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 1");
            Console.Write("Nhập độ C: ");
            double celsius = double.Parse (Console.ReadLine());
            double kelvin = celsius + 273.15;
            double faherenheit = celsius * 18.0 / 10 + 32;
            Console.WriteLine($"Độ K: {kelvin}");
            Console.WriteLine($"Độ F: {faherenheit}");
        }
    }
}
