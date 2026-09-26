using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_1_lại
{
    internal class Bài_tập_5
    {
        public static void Main36(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập điểm số môn lập trình c#");
            double laptrinh=double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ môn lập trình c#");
            int tinchic= int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm số môn toán rời rạc");
            double toan= double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ môn toán rời rạc");
            int tinchitoan= int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm số môn tiếng anh");
            double tienganh= double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ môn tiếng anh");
            int tinchitienganh = int.Parse(Console.ReadLine());
            double scoreaverage = (laptrinh * tinchic + toan * tinchitoan + tienganh * tinchitienganh) / tinchic + tinchitoan + tinchitienganh;
            Console.WriteLine($"điểm trung bình thanh 10 là:{scoreaverage}");
            string diem_chu;
            double thang_diem;
            string xep_loai;
            if(scoreaverage>=8.5)
            { }    
        }
        }
}
