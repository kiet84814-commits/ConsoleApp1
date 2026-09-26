using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01
{
    internal class Bai_tap_7
    {
        public static void Main28(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 7");
            Console.WriteLine("Nhập tên thô ");
            string trimmedInput = Console.ReadLine().Trim();
            string[] words = trimmedInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string result = string.Join(" ", words);
            Console.WriteLine("Tên đã được xử lý: " + result);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToLower();
                words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1);
            }
            Console.WriteLine("Tên đã được xử lý: " + string.Join(" ", words));
            string ten= words[words.Length -1 ];
            string hovatendem= string.Join(" ", words, 0, words.Length - 1);
            Console.WriteLine("Tên cuối cùng: " + ten);
            Console.WriteLine("Họ và tên đệm: " + hovatendem);
            string username= ("" + ten + "." + hovatendem).ToLower();
            Console.WriteLine("Tên đăng nhập: " + username);
            username = username.Replace(" ", "");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("đ", "d");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("Đ", "D");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("á", "a");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("à", "a");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("ả", "a");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("ã", "a");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("ạ", "a");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("â", "a");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("ă", "a");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("é", "e");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("è", "e");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("ẻ", "e");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("ẽ", "e");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("ẹ", "e");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("ê", "e");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("í", "i");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("ì", "i");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("ỉ", "i");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("ĩ", "i");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("ị", "i");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username = username.Replace("ó", "o");
            Console.WriteLine("Tên đăng nhập đã được xử lý: " + username);
            username= username+"@company.edu.vn";
            Console.WriteLine("Tên đăng nhập cuối cùng: " + username);
        }
    }
}
