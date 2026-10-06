using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2_bài_thi_giữa_kỳ
{
    internal class bài_tập_1
    {
        public static double CalculateDrinkPrice(int drinkType, char size)
        {
            switch(drinkType)
            {
                case 1:
                    if (size == 'S') return 30000;
                    if (size == 'M') return 40000;
                    if (size == 'L') return 50000;
                    break;
                case 2
                    :
                    if (size == 'S') return 35000;
                    if (size == 'M') return 45000;
                    if (size == 'L') return 55000;
                    break;
                case 3
                    :
                    if (size == 'S') return 45000;
                    if (size == 'M') return 55000;
                    if (size == 'L') return 65000;

                    break;

            }
            return 0;
        }
        public static double ApplyDiscount(double totalAmount, int hour, bool isStudent)
        {
            if(hour>=8 && hour<=10)
            {
                totalAmount *= 0.8;

            }
            if(isStudent==true)
            {
                totalAmount *= 0.9;
            }
            return totalAmount;
        }
        public static void ProcessSingleOrder()
        {
            Console.WriteLine("Nhập số lượng đồ uống khách muốn gọi trong 1 hóa đơn");
            int n=int.Parse(Console.ReadLine());
            double basePrice = 0;
            for (int i=1;i<=n; i++)
            {
                Console.WriteLine("Nhập mã đồ uống");
                int drinkType = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập size đồ uống");
                char size = char.Parse(Console.ReadLine());
                double result= CalculateDrinkPrice(drinkType, size);
                basePrice += result;

            }
            Console.WriteLine($"Số tiền gốc là:{basePrice}");
            Console.WriteLine("Nhập giờ hiện tại");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Bạn có phải là học sinh/sinh viên không? (Y/N)");
            char isStudentInput = char.Parse(Console.ReadLine());
            bool isStudent = (isStudentInput == 'Y' || isStudentInput == 'y');
            double discount = ApplyDiscount(basePrice, hours, isStudent);
            Console.WriteLine($"Số tiền sau giảm giá:{discount}");
            double finalPrice=basePrice - discount;
            Console.WriteLine($"Số tiền thực tế là{finalPrice}");
        }
    }
}
