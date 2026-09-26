using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_01_two
{
    internal class Bài_tập_4
    {
        public static void Main4(string[] args)
        {
         Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 4");
            Console.WriteLine("Nhập ngày tháng năm sinh (dd/MM/yyyy): ");
            DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime birthDate);
            Console.WriteLine($"Ngày tháng năm sinh: {birthDate:dd/MM/yyyy}");
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Ngày hiện tại: " + currentDate.ToString("dd/MM/yyyy"));
            int age = currentDate.Year - birthDate.Year;
            Console.WriteLine($"Tuổi: {age}");
            double daysLived = (currentDate - birthDate).TotalDays;
            Console.WriteLine("Số ngày đã sống: " + daysLived);


        }
    }
}
