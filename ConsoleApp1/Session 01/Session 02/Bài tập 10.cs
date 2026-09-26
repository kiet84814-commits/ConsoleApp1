using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_02
{
    internal class Bài_tập_10
    {
        enum money
        {
            USD = 25400,
            EUR = 27200,
            JPY = 165,
        }
        public static void Main7(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 10");
            Console.WriteLine("Nhập số tiền: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Nhập loại tiền tệ (USD, EUR, JPY): ");
            string currency = Console.ReadLine()?.ToUpper();
            switch (currency)
            {
                case "USD":
                    Console.WriteLine($"số tiền sau quy đổi: {amount / (int)money.USD:F2} USD");
                    break;
                case "EUR":
                    Console.WriteLine($"số tiền sau quy đổi: {amount / (int)money.EUR:F2} EUR");
                    break;
                case "JPY":
                    Console.WriteLine($"số tiền sau quy đổi: {amount / (int)money.JPY:F2} JPY");
                    break;
                default:
                    Console.WriteLine("Loại tiền tệ không hợp lệ");
                    break;
            }
        }
    }
}
