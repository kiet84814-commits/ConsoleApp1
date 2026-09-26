using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_1_lại
{
    internal class Bài_tập_8
    {
        public static void Main37(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string systemOTP = "839201";
            DateTime creationTime = DateTime.Now;
            Console.WriteLine("Người dùng nhập mã OTP");
            string OTP= (Console.ReadLine());
            Console.WriteLine("nhập thời gian gửi xác nhận");
            if(!int.TryParse(Console.ReadLine(), out int elapsedSeconds))
            {
                Console.WriteLine("Thời gian không hợp lệ");
                return;
            }
            if(OTP.Length !=6 || !int.TryParse(OTP,out _))
            {
                Console.WriteLine("Lỗi độ dài ký tự không bằng 6 và không phải toàn số");
                return;
            }
            if (OTP != systemOTP)
            {
                Console.WriteLine("Trạng thái xác thực: LỖI - Mã OTP không chính xác.");
                return;
            }
            if(elapsedSeconds>300)
            {
                Console.WriteLine("quá thời gian quy định 300 giây");
                return;
            }
            Console.WriteLine("Thành công");

        }
        }
}
