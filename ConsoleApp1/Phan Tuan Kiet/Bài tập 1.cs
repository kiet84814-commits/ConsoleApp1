using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace ConsoleApp1.Phan_Tuan_Kiet
{
    internal class Bài_tập_1
    {
        public static double CalculateBaseTicketPrice(double height, int age)
        {

            if (age >= 60)
            {
                return 40.000;
            }
            else if (height < 1.2)
            {
                return 50.000;



            }
            else
            {
                return 100.000;
            }
             

        }
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhập vào chiều cao");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("nhập vào tuổi");
            int age = int.Parse(Console.ReadLine());
        }
    }
}
