using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_02
{
    internal class Bài_tập_9
    {
        public static void Main13(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 9");
            Console.WriteLine("Nhập điểm trung bình tích lũy: ");
                double gpa = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm rèn luyện: ");
            double conductScore = double.Parse(Console.ReadLine());
            if (gpa >= 3.6 && conductScore >= 90)
            {
                Console.WriteLine("Học bổng xuất sắc (mức 100%)");
            }
            else if (gpa >= 3.2 && conductScore >= 80)
            {
                Console.WriteLine("Học bổng khá/giỏi (mức 50%)");
            }
        }
    }
}
