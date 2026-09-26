using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_01_two
{
    internal class Bài_tập_3
    {
        enum CurrencyType
        {
            USD = 1,
            EUR = 2,
            GBP = 3,
            JPY = 4,
        }
        public static void Main3(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 3");
            Console.Write("Nhập số tiền: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Chọn ngoại tệ (USD, EUR, GBP, JPY, AUD): ");
            CurrencyType currency = (CurrencyType)Convert.ToInt32(Console.ReadLine());
            decimal exchangeRate = 0m;
            switch (currency)
            {
                case CurrencyType.USD:
                    exchangeRate = 25.400m;
                    break;
                case CurrencyType.EUR:
                    exchangeRate = 27.200m;
                    break;
                case CurrencyType.GBP:
                    exchangeRate = 32.100m;
                    break;
                case CurrencyType.JPY:
                    exchangeRate = 165m;
                    break;
            }
            decimal serviceFee = amount  * 0.005m;
            Console.WriteLine($"Phí dịch vụ: {serviceFee:F2}");
            decimal totalAmount = amount - serviceFee;
            Console.WriteLine($"Số tiền thực nhận: {totalAmount:F2}");
            decimal convertedAmountInForeignCurrency = totalAmount / exchangeRate;
            Console.WriteLine($"Số tiền ngoại tệ: {convertedAmountInForeignCurrency:F2}");
       

    }
    }
}
