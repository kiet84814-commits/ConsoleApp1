using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ConsoleApp1.Session_01
{
    internal class Bai_tap_6
    {
        public static void Main27(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 6");
            Console.WriteLine(" Môn lập trình C#");
            Console.WriteLine("Nhập điểm số: ");
            double score = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ: ");
            int credit = int.Parse(Console.ReadLine());
            Console.WriteLine($"Điểm số: {score}, Số tín chỉ: {credit}");
            Console.WriteLine(" Môn toán rời rạc");
            Console.WriteLine("Nhập điểm số: ");
            double mathScore = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ: ");
            int mathCredit = int.Parse(Console.ReadLine());
            Console.WriteLine($"Điểm số: {mathScore}, Số tín chỉ: {mathCredit}");
            Console.WriteLine(" Tiếng ANh");
            Console.WriteLine("Nhập điểm số: ");
            double englishScore = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ: ");
            int englishCredit = int.Parse(Console.ReadLine());
            Console.WriteLine($"Điểm số: {englishScore}, Số tín chỉ: {englishCredit}");
            double score_average= (score * credit + mathScore * mathCredit + englishScore * englishCredit) / (credit + mathCredit + englishCredit);
            string diem_chu;
            double thang_diem;
            string xep_loai;
            if (score_average >= 9)
            {
                diem_chu = "A";
                thang_diem = 4;
                xep_loai = "Xuất sắc";
            }
            else if (score_average >= 8)
            {
                diem_chu = "B";
                thang_diem = 3;
                xep_loai = "Giỏi";
            }
            else if (score_average >= 7)
            {
                diem_chu = "C";
                thang_diem = 2;
                xep_loai = "Khá";
            }
            else if (score_average >= 6)
            {
                diem_chu = "D";
                thang_diem = 1;
                xep_loai = "Trung bình";
            }
            else
            {
                diem_chu = "F";
                thang_diem = 0;
                xep_loai = "Yếu";
            }

        }
    }
}
