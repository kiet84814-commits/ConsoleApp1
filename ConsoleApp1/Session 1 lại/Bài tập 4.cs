using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_1_lại
{
    internal class Bài_tập_4
    {
        public static void Main35(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập ngày sinh (dd/MM/yyyy): ");
            if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dt))
            {
                DateTime Now = DateTime.Now.Date;
                int tuổi = Now.Year - dt.Year;
                Console.WriteLine($" số tuổi là:{tuổi}");
                double ngaysong = (Now - dt).Days;
                Console.WriteLine($" số ngày là:{ngaysong}");


                DateTime nextBirthday = new DateTime(Now.Year, dt.Month, dt.Day);
                if (nextBirthday < Now)
                {
                    nextBirthday = nextBirthday.AddYears(1);
                }
                int ngaysinhnhattieptheo = (nextBirthday - Now).Days;
                Console.WriteLine($"số ngày tới sinh nhật tiếp theo là:{ngaysinhnhattieptheo}");
            }
        }
        }
}
