using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_02
{
    internal class Bài_tập_1
    {
        public static void Main6(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 1");
            Console.WriteLine("Nhập số tuổi");
            double age = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giờ chiếu phim");
            double time = double.Parse(Console.ReadLine());
            if (age > 60 || age < 12)
                Console.WriteLine("Giá vé là 50.000 VNĐ");
            else if (age >= 12 && age <= 60)
            {
                if ( time < 17)
                    Console.WriteLine("Giá vé là 80.000 VNĐ");
                else
                    Console.WriteLine("Giá vé là 110.000 VNĐ");
            }
        }
    }
}
