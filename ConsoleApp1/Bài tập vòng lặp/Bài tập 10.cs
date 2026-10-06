using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập_vòng_lặp
{
    internal class Bài_tập_10
    {
        public static double TinhTrungBinh(int[] arr)
        {
            int tong = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                tong += arr[i];
                
            }
            return (double)tong / arr.Length;
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào chuỗi");
            int[] numbers = { 4, 5, 6, 7 };
            double result = TinhTrungBinh(numbers);
            Console.WriteLine($"Kết quả là:{result}");
        }
        }
}
