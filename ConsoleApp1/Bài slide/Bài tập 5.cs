using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_slide
{
    internal class Bài_tập_5
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhập giá trị n");
            int n=int.Parse(Console.ReadLine());
            for (int i=1; i<=n; i++)
            {
                for(int j=1;j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }    

        }
        }
}
