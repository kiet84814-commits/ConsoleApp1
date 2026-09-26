using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_04_BTVN
{
    internal class Bài_tập_6
    {
        public static bool KiemTraNguyenTo(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main49(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(" Nhập số nguyên n ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Kết quả kiểm tra số nguyên tố: {KiemTraNguyenTo(n)}");
        }
    }

            }
   
