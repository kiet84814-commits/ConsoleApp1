using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_1_lại
{
    internal class Bài_tập_3
    {
        enum Currencytype
        {
            USD = 1,
                EUR,
                JPY,
                GBP,


        }
        public static void Main34(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập số tiền VNĐ");
            decimal VNĐ= decimal.Parse(Console.ReadLine());
            decimal USDrate= 25400 ;
            decimal EURrate = 27200;
            decimal JPYrate = 165;
            decimal GBPrate = 32100;
            Console.WriteLine("chọn loại ngoại tệ muốn đổi (1-USD, 2-EUR, 3-JPY, 4-GBP):");
            int chon= int.Parse(Console.ReadLine());
            Currencytype currency = (Currencytype)chon;
            decimal phidichvu = VNĐ * 0.005m;
            Console.WriteLine($"Phí dịch vụ là:{phidichvu}");
            decimal sotienVNĐthucte = VNĐ - phidichvu;
            Console.WriteLine($"số tiền VNĐ thực tế là:{sotienVNĐthucte}");
            decimal result = 0;
            switch (currency)
            {
                case Currencytype.USD:
                    result = sotienVNĐthucte / USDrate;
                    break;
                case Currencytype.EUR:
                    result = sotienVNĐthucte / EURrate;
                    break;
                case Currencytype.JPY:
                    result = sotienVNĐthucte / JPYrate;
                    break;
                case Currencytype.GBP:
                    result = sotienVNĐthucte / GBPrate;
                    break;
            }
            Console.WriteLine($"Số tiền USD nhận được là:{result:F2}");
            



        }
        }
}
