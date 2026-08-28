using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ConsoleApp1.Session_01
{
    public class Bài_tập_3
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 3");
            Console.Write("Nhập chiều cao: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Nhập cân nặng: ");
            double weight = double.Parse(Console.ReadLine());
            double bmi = weight / (height * height);
            Console.WriteLine($"Chỉ số BMI: {bmi:F2}");
            double minwei = 18.5 * (height * height);
            Console.WriteLine($"Chỉ số BMI tối thiểu: {minwei:F2}");
            double maxwei = 22.9 * (height * height);
            Console.WriteLine($"Chỉ số BMI tối đa: {maxwei:F2}");
            if (bmi < 18.5)
            Console.WriteLine("Gầy");
            else if (bmi >= 18.5 && bmi <= 22.9)
            {
                Console.WriteLine("Bình thường");
            } 
            else if (bmi >= 22.9 && bmi < 25)
            { 
                Console.WriteLine("Thừa cân");
            } 
            else if (bmi >= 25)
            {
                Console.WriteLine("Béo phì");
            }
            
            {
            }
        }
    }
}