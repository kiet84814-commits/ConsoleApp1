using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp1.Session_3_lại
{
    internal class Bài_tập_2
    {
        public static bool KiemTraChan(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
                
            }
        }
             public static void Main39(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào số nguyên n");
            int n = int.Parse(Console.ReadLine());
            bool result = KiemTraChan(n);
            if(result)
            {
                Console.WriteLine($"n là số chẵn");
            }    
            else
            {
                Console.WriteLine($"n là số lẻ");
            }    

        }   
       

    }
}
