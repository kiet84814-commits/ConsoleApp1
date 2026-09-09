using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01
{
    public class Bài_tập_2
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 2");
            Console.Write("Nhập chiều cao");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cân nặng");
            double weight = double.Parse(Console.ReadLine());
            double bmi = weight / (height * height);
            Console.WriteLine($"Chỉ số BMI của bạn là: {bmi:F2}");
            if (bmi < 18.5)
            {
                Console.WriteLine("Bạn đang gầy");
            }
            else if (bmi >= 18.5 && bmi <= 22.9)
            {
                Console.WriteLine("Bạn đang bình thường");
            }
            else if (bmi >= 22.9 && bmi < 25)
            {
                Console.WriteLine("Bạn đang thừa cân");
            }
            else if (bmi >= 25)
            {
                Console.WriteLine("Bạn đang béo phì");
            }
            double cân_nặng_tối_thiểu = 18.5 * (height * height);
            double cân_nặng_tối_đa = 22.9 * (height * height);
            Console.WriteLine($"Khuyên dùng: Cân nặng tối thiểu: {cân_nặng_tối_thiểu:F2} đến {cân_nặng_tối_đa:F2}");


        }
    }
}
