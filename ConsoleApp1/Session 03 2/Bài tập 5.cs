using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_03_2
{
    internal class Bài_tập_5
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n = 4;
            for(int i=1;i<=n; i++)
            {
                for(int j=1;j<=i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }    
        }
        }
}
