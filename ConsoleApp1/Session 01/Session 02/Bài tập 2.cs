using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_02
{
    internal class Bài_tập_2
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 2");
           Console.WriteLine("Nhập vai trò");
            string role = Console.ReadLine();
            switch (role)
            {
                case "admin":
                    Console.WriteLine("Admin");
                    Console.WriteLine("Toàn quyền quản trị hệ thống");
                    break;
                case "manager":
                    Console.WriteLine("Manager");
                    Console.WriteLine("Quyền quản lý nhân sự và xem báo cáo");
                    break;
                case "employee":
                    Console.WriteLine("Employee");
                    Console.WriteLine("Quyền tạo và chỉnh sửa hồ sơ cá nhân");
                    break;
                case "guest":
                    Console.WriteLine("Guest");
                    Console.WriteLine("Quyền xem thông tin công khai");
                    break;
                default:
                    Console.WriteLine("Vai trò không hợp lệ");
                    break;
            }
        }
    }
}
