using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập_vòng_lặp
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
            if(c> max)
            {
                max = c;

            }

            return max;
        

                
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên a");
            Console.WriteLine("Nhập số nguyên b");
            Console.WriteLine("Nhập số nguyên c");
            int a= int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());
            int c= int.Parse(Console.ReadLine());
            int result = TimMax(a, b, c);
            Console.WriteLine($"số lớn nhất là:{result}");

        }
    }
}
