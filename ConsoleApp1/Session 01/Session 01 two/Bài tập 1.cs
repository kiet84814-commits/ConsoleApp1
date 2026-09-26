using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_01_two
{
    internal class Bài_tập_1
    {
        public static void Main1(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 1");
            Console.WriteLine("Nhập chỉ số điện cũ: ");
            decimal oldElectricIndex = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chỉ số điện mới: ");
            decimal newElectricIndex = decimal.Parse(Console.ReadLine());
            decimal consumption = newElectricIndex - oldElectricIndex;
            Console.WriteLine($"Số điện tiêu thụ là: {consumption}");
            decimal totalbeforetax = 0;
            if (consumption <= 50)
            {
                totalbeforetax = consumption * 1806;
            }
            else if (consumption > 50 && consumption <= 100)
            {
                totalbeforetax = (50 * 1806) + ((consumption - 50) * 1866);
            }
            else if (consumption > 100 && consumption <= 200)
            {
                totalbeforetax = (50 * 1806) + (50 * 1866) + ((consumption - 100) * 2167);
            }
            else if (consumption > 200 && consumption <= 300)
            {
                totalbeforetax = (50 * 1806) + (50 * 1866) + (100 * 2167) + ((consumption - 200) * 2729);
            }
            else if (consumption > 300)
            {
                totalbeforetax = (50 * 1806) + (50 * 1866) + (100 * 2167) + (100 * 2729) + ((consumption - 300) * 3050);
            }
            Console.WriteLine($"Tổng tiền điện trước thuế là: {totalbeforetax}");
            decimal totalaftertax = totalbeforetax * 0.08m;
            Console.WriteLine($"Thuế là: {totalaftertax}");
            decimal total = totalbeforetax + totalaftertax;
            Console.WriteLine($"Tổng tiền điện sau thuế là: {total}");
            Console.ReadKey();
        }
    }
}
