using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_02
{
    internal class Bài_tập_8
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 8");
            Console.WriteLine("Nhập loại xe: ");
            string vehicleType = Console.ReadLine();
            Console.WriteLine("Nhập thời gian gửi");
            int hours = int.Parse(Console.ReadLine());
            switch (vehicleType)
            {
                case "Xe đạp":
                if (hours == 1)
                       Console.WriteLine("Phí gửi xe đạp là: 5000 vnđ");
                   else if (hours == 2)
                    {
                        Console.WriteLine("Phí gửi xe đạp là: 10000 vnđ");
                    }
                    break;
                case "Ô tô":
                if (hours == 1)
                    Console.WriteLine("Phí gửi xe ô tô là: 30000 vnđ");
                   else if (hours == 2)
                    {
                        Console.WriteLine("Phí gửi xe ô tô là: 600000 vnđ");
                    }
                    break;
                default:
                    Console.WriteLine("Loại xe không hợp lệ");
                    break;  

            }
        }
    }
}
