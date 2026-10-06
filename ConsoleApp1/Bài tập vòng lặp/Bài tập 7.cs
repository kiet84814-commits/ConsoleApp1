using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập_vòng_lặp
{
    internal class Bài_tập_7
    {
        public static void InFibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 1; i <= n; i++) 
            {
                Console.Write(a + " ");
                int next = a + b;
                a = b;
                b = next;
               


            }
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào n");
            int n = int.Parse(Console.ReadLine());
            InFibonacci(n);
         
            
        }
        }
}
