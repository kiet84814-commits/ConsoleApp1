using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp1.Session_3_lại
{
    internal class Bài_tập_10
    {
        public static double TinhTrungBinh(int[] arr)
        {
            double tong = 0;
            for(int i=0; i<arr.Length;i++)
            {
                tong += arr[i];
            }
            return tong / arr.Length;

        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[] Numbers= { 4, 5, 6, 7 };
            double ketqua = TinhTrungBinh(Numbers);
            Console.WriteLine($"kết quả là:{ketqua}");
        }
        }
}
