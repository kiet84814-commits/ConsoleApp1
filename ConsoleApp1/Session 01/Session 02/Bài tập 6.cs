using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_02
{
    internal class Bài_tập_6
    {
        public static void Main12(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 6");
            Console.WriteLine("Nhập mã đơn hàng: ");
            int orderCode = int.Parse(Console.ReadLine());
            switch (orderCode) {

                case 1:
                    Console.WriteLine("Chờ xác nhận thanh toán");
                    break;
                case 2:
                    Console.WriteLine("Đang đóng gói và bàn giao đơn vị vận chuyển.");
                        break;
                case 3:
                    Console.WriteLine("Đơn hàng đang trên đường giao đến bạn.");
                    break;
                case 4:
                    Console.WriteLine("Đơn hàng đã hoàn thành. Cảm ơn bạn!");
                    break;
                default:
                    Console.WriteLine("Đơn hàng đã hủy. Xuất phiếu hoàn tiền.");
                    break;

        }
        }
    }
}
