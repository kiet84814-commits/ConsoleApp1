using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01
{
    internal class Bài_tập_9
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 9");
            string correctOTP = "839201";
            Console.Write("Nhập mã OTP: ");
             DateTime creationtime = DateTime.Now;
            Console.Write("Mã OTP nhận được: ");
            string useroTP = Console.ReadLine();

        }
    }
}
