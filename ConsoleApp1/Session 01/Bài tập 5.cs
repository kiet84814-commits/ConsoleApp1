using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01
{
    public class Bài_tập_5
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 5");
            Console.Write("Nhập ngày tháng năm sinh (dd/MM/yyyy): ");
            DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dt);
            DateTime now = DateTime.Now;
            int age = now.Year - dt.Year;
            Console.WriteLine($"Tuổi của bạn là: {age}");
            DateTime nextBirthday = new DateTime(now.Year, dt.Month, dt.Day);
            if (nextBirthday < now)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            TimeSpan timeRemaining = nextBirthday - now;
            Console.WriteLine($"Số ngày còn lại đến sinh nhật tiếp theo: {timeRemaining.Days}");
            int totaldayslived = (now - dt).Days;
            Console.WriteLine($"Tổng số ngày bạn đã sống: {totaldayslived}");
        }
    }
}
