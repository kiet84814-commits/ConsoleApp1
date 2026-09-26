using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_01_two
{
    internal class Bài_tập_5
    {
        public static void Main5(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 5");
            Console.WriteLine("Nhập điểm số môn lập trình C#: ");
            double score = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ");
            int credit = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm môn toán rời rạc: ");
            double discreteMathScore = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ môn toán rời rạc: ");
            int discreteMathCredit = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm số môn tiếng anh: ");
            double englishScore = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ môn tiếng anh: ");
            int englishCredit = int.Parse(Console.ReadLine());
            double average = (score * credit + discreteMathScore * discreteMathCredit + englishScore * englishCredit) / (credit + discreteMathCredit + englishCredit);
            Console.WriteLine($"Điểm trung bình: {average:F2}");
            if (average >= 8.5)
            {
                Console.WriteLine("Xếp loại: Giỏi");
                string scoreletter = "A";
                Console.WriteLine(scoreletter);
                double gpa = 4.0;
            }
            else if (average > 7&& average <= 8.4)
            {
                Console.WriteLine("Xếp loại: Khá");
                string scoreletter = "B";
                Console.WriteLine(scoreletter);
                double gpa = 3.0;
            }
            else if (average >5 && average <= 6.9)
            {
                Console.WriteLine("Xếp loại: Trung bình");
                string scoreletter = "C";
                Console.WriteLine(scoreletter);
                double gpa = 2.0;
            }
            else
            {
                Console.WriteLine("Xếp loại: Yếu");
                string scoreletter = "D";
                Console.WriteLine(scoreletter);
                double gpa = 1.0;
            }

        }
    }
}
