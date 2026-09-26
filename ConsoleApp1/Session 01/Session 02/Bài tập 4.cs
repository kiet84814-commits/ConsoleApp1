using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_02
{
    internal class Bài_tập_4
    {
        public static void Main10(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 4");
            Console.WriteLine("Nhập số phím khách hàng muốn nhập: ");
            int n = int.Parse(Console.ReadLine());
            switch(n)
                            {
                case 1:
                    Console.WriteLine("Gặp tổng đài tư vấn thẻ");
                    break;
                case 2:
                    Console.WriteLine("Tra cứu số dư tài khoản");
                    break;
               case 3:
                    Console.WriteLine("Báo khóa thẻ khẩn cấp");
                    break; 
                case 4:  
                    Console.WriteLine("tra cứu tỷ giá ngoại tệ");
                    break; 
                case 0:
                    Console.WriteLine("quay lại menu chính");
                    break;
                default:
                    Console.WriteLine("lựa chọn không hợp lệ. Vui lòng thử lại");
                    break;
            }
        }
    }
}
