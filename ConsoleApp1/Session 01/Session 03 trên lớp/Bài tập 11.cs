using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_03_trên_lớp
{
    internal class Bài_tập_11
    {
        public static void Main15(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 11");
            Console.WriteLine("Nhập độ dài cạnh a)");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập độ dài cạnh b)");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập độ dài cạnh c)");
            double c = double.Parse(Console.ReadLine());
           if(a>0 && b>0 && c>0 && a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Đây là 3 cạnh của một tam giác");
            }
            else
            {
                Console.WriteLine("Đây không phải là 3 cạnh của một tam giác");
                return;
            }

            if (a == b && b == c)
            {
                Console.WriteLine("Tam giác đều");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Tam giác cân");
            }
            else
            {
                Console.WriteLine("Tam giác thường");
            }
            
        }
    }
}
