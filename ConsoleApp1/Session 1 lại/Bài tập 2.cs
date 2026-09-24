using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1.Session_1_lại
{
    internal class Bài_tập_2
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào chiều cao");
            double chieucao= double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào cân nặng");
            double cannang= double.Parse(Console.ReadLine());
            double BMI = cannang / Math.Pow(chieucao, 2);
            Console.WriteLine($"chỉ số BMI của bạn là:{BMI}");
            if (BMI < 18.5)
            {
                Console.Write("Gầy");
            } 
            else if(BMI>=18.5 && BMI<23)
            {
                Console.Write("Bình thường");
            }    
            else if(BMI>=23.0 && BMI<25)
            {
                Console.Write("Thừa cân");
            }  
            else
            {
                Console.Write("Béo phì");
            }
            double cannangtoithieu = 18.5 * Math.Pow(chieucao, 2);
            double cannangtoida = 22.9 * Math.Pow(chieucao, 2);
            Console.WriteLine($"cân nặng nặng lý thưởng của bạn nên từ: {cannangtoithieu:F2} đến {cannangtoida:F2} ");
        }
        }
}
