using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01.Session_02
{
    internal class Bài_tập_7
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 7");
            Console.WriteLine("Nhập chiều cao: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cân nặng: ");
            double weight = double.Parse(Console.ReadLine());
            double bmi = weight / (height * height);
            Console.WriteLine("Chỉ số BMI của bạn là: " + bmi);
            if (bmi < 18.5)
            {
                Console.WriteLine("Thầy gầy - Nên bổ sung dinh dưỡng.");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("Cân đối - Tiếp tục duy trì.");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("Thừa cân - Nên tăng cường luyện tập.");
            }
            else
            {
                Console.WriteLine("Béo phì - Cần sự tư vấn từ bác sĩ.");
            }
        }
    }
}
