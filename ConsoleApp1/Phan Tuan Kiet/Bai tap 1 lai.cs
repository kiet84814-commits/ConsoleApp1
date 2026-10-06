using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1.Phan_Tuan_Kiet
{
    internal class Bai_tap_1_lai
    {
        public static double CalculateBaseTicketPrice(double height, int age)
        {
            if(age>=60)
            {
                return 40000;
            } 
            else if(height<1.2)
            {
                return 50000;
            }  
            else
            {
                return 100000;
            }
            
        }
         static double ApplyDiscount(double totalAmount, string dayOfWeek, bool isMember)
        {
            if(dayOfWeek=="tuesday")
            {
                totalAmount *= 0.9;
            }
            else if(dayOfWeek=="wednesday")
            {
                totalAmount *= 0.85;
            } 
             if(isMember==true)
            {
                totalAmount *= 0.95;
            }
            return totalAmount;
            
        }
        public static void ProcessSingleOrder()
        {
            Console.WriteLine("Nhập số lượng khách hàng trong nhóm");
            int n=int.Parse(Console.ReadLine());
            double totalAmount = 0;
            for(int i=1;i<=n;i++)
            {
                Console.WriteLine("Nhập chiều cao của từng người");
                double height=double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập tuổi của từng người");
                int age=int.Parse(Console.ReadLine());
                totalAmount += CalculateBaseTicketPrice( height,  age);
            }
            Console.WriteLine($"Số tiền tổng là:{totalAmount}");
            Console.WriteLine("Nhập ngày trong tuần");
            string dayofWeek= (Console.ReadLine());
            Console.WriteLine("Có phải thành viên hay không");
            bool member=bool.Parse(Console.ReadLine());
            double finalPrice = ApplyDiscount(totalAmount, dayofWeek, member);
            double discount = totalAmount - finalPrice;
            Console.WriteLine($"Số tiền giảm giá là:{discount}");
            Console.WriteLine($"số tiền cuối cùng là:{finalPrice}");

        }

    }
    internal class Baitap2
    {
        public static int ReadValidInt(string prompt, int min, int max)
        {
            int val;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out val) || val < min || val > max)
            {
                Console.WriteLine($"[Lỗi] Giá trị phải từ {min} đến {max}. Vui lòng nhập lại!");
                Console.Write(prompt);

            }
            return val;
        }
        public static double CalculateOptimalPrice(int adultCount, int childCount, int seniorCount)
        {
            double regularPrice = (adultCount * 100000) + (childCount * 50000) + (seniorCount * 70000);
            double minPrice = regularPrice;
            if (adultCount == 2 && (childCount == 1 || childCount == 2))
            {
                double familyPrice = 220000 + (seniorCount * 70000);
                if (familyPrice < minPrice) minPrice = familyPrice;
            }
            int totalpeople = adultCount + childCount + seniorCount;
            if (totalpeople >= 5 && adultCount >= 1)
            {
                double groupPrice = regularPrice - 100000;
                if (groupPrice < minPrice) minPrice = groupPrice;
            }
            return minPrice;
        }
        public static void RunDailyPOS()
        {
            int totalOrders = 0;
            double totalRevenue = 0;
            double maxOrderValue = 0;
            string choice;
            do
            {
                Console.WriteLine($"\n----- NHẬP ĐƠN HÀNG SỐ{totalOrders + 1}---");
                int adultCount = ReadValidInt("Nhập số lượng người lớn(0-100):", 0, 100);
                int childCount = ReadValidInt("Nhập số lượng trẻ em(0-100):", 0, 100);
                int seniorCount = ReadValidInt("Nhập số lượng người cao tuổ(0-100):", 0, 100);
                double finalPrice = CalculateOptimalPrice(adultCount, childCount, seniorCount);
                Console.WriteLine($"=> số tiền tối ưu của đơn hàng:{finalPrice:N0}VNĐ");
                totalOrders++;
                totalRevenue += finalPrice;
                if (finalPrice > maxOrderValue) maxOrderValue = finalPrice;
                do
                {
                    Console.Write("\n Bạn có muốn nhập đơn hàng tiếp theo không?(Y/N):");
                    choice = Console.ReadLine().Trim().ToUpper();
                } while (choice != "Y" && choice != "N");
            } while (choice == "Y");
            Console.Write($@"\n Báo cáo tổng kết doanh thu ngày:
            Tổng số đơn hàng đã hoàn tất:{totalOrders}
            Tổng doanh thu thực tế:{totalRevenue:N0}VNĐ
            Giá trị đơn hàng lớn :{maxOrderValue:N0}VNĐ");
        }
        public static void Run()
        {
            RunDailyPOS();
           
        }
        internal class program
        {
        }
}


}
