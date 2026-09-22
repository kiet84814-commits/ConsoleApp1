using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_04_BTVN
{
    internal class Bài_tập_10
    {
        public static double TinhTrungBinh(int[] arr)
        {
        double sum = 0;
        foreach (int num in  arr)
            {
            sum += num;
            }
    return sum / arr.Length;
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhập mảng số nguyên mẫu");
            string input = Console.ReadLine();

        }
        }
}
