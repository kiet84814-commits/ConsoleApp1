using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01
{
    enum Currencytype
    {
        USD = 1,
        EUR,
        JPY,
        GBP,
    }
    public class Bài_tập_4
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 4");
            Console.Write("Nhập số tiền VND: ");
            decimal vnd = decimal.Parse(Console.ReadLine());
            decimal rateUSD = 25400m;
            decimal rateEUR = 27200m;
            decimal rateJPY = 165000m;
            decimal rateGBP = 32100m;
            Console.Write(" chọn ngoại tệ (1: USD, 2: EUR, 3: JPY, 4: GBP): ");
            int choice = int.Parse(Console.ReadLine());
            Currencytype currency = (Currencytype)choice;
            decimal phí = vnd * 0.005m;
            decimal vndthucte = vnd - phí;
            decimal result = 0m;
            switch (currency)
            {
                case Currencytype.USD:
                    result = vndthucte / rateUSD;
                    break;
                case Currencytype.EUR:
                    result = vndthucte / rateEUR;
                    break;
                case Currencytype.JPY:
                    result = vndthucte / rateJPY;
                    break;
                case Currencytype.GBP:
                    result = vndthucte / rateGBP;
                    break;
            }
            Console.WriteLine($"Phí dịch vụ (0.5%): {phí:N0} VNĐ");
            Console.WriteLine($"Số tiền VND tính đổi:{vndthucte:N0}VNĐ ");
            Console.WriteLine($"Số tiền nhận được:{result:F2} {currency}");
        }
    }
}