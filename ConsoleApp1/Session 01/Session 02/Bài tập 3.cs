using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ConsoleApp1.Session_01.Session_02
{
    internal class Bài_tập_3
    {
        public static void Main9(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 3");
            Console.WriteLine("Nhập số dư tài khoản");
            decimal balance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tiền muốn rút");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
            if (withdrawAmount <= 0)
            {
                Console.WriteLine("Thông báo rút tiền thất bại");
            }
            else if (withdrawAmount % 50000 != 0) {
                Console.WriteLine("Thông báo rút tiền thất bại:số tiền rút phải là bội số của 50000 VNĐ");
            }
            else if (withdrawAmount > balance)
            {
                Console.WriteLine("từ chối số tiền vượt quá số tiền hiện tại");
            }
            else if (withdrawAmount > 500000)
            {
                Console.WriteLine("Thông báo rút tiền thất bại:số tiền rút phải nhỏ hơn hoặc bằng 500000 VNĐ");
            }
            else
            {
                Console.WriteLine("Giao dịch thành công.số dư còn lại: {0}", balance-=withdrawAmount);  
            }
        }
    }
}