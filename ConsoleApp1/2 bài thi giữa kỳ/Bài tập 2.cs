using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2_bài_thi_giữa_kỳ
{
    internal class Bài_tập_2
    {
        public static int ReadValidInt(string prompt, int min, int max)
        {
            int result;
            bool isValid;
            do
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out result);
                if(!isValid)
                {
                    Console.WriteLine("Vui lòng nhập lại.");
                    
                }
                else if(result<min || result>max)

                {
                    Console.WriteLine($"Vui lòng nhập lại khoảng từ {min} đến {max}");
                    isValid = false;
                }


            } while (!isValid);
            return result;

        }
        public static char ReadValidChar(string prompt, char val1, char val2, char val3)
        {
            char result;
            bool isValid;
            do
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                isValid = char.TryParse(input, out result);
                if (!isValid)

                {
                    Console.WriteLine("Vui lòng nhập lại.");
                }
                else if (result != val1 && result != val2 && result != val3)
                {
                    Console.WriteLine($"Vui lòng nhập lại {val1};{val2};{val3}");
                    isValid = false;
                }

            } while (!isValid);
            return result;
        }
        public static void RunDailyManagement()
        {
            int totalOrders = 0;
            int totalRevenue = 0;
            int totalitems = 0;
            int quantity = 0;
            int price = 0;
            do
            {
                Console.WriteLine("Nhập số lượng ly)");
                quantity = ReadValidInt("Nhập số lượng ly (1-100):", 1, 100);
                totalitems += quantity;
                price = ReadValidInt("Nhập giá tiền (10000-100000):", 10000, 100000);
                totalRevenue += quantity * price;
                totalOrders++;
            } while (ReadValidChar("Bạn có muốn tiếp tục nhập không? (Y/N):", 'Y', 'y', 'N') == 'Y');
            Console.WriteLine($"Tổng số đơn hàng: {totalOrders}");
            Console.WriteLine($"Tổng số ly đã bán: {totalitems}");
            Console.WriteLine($"Tổng doanh thu: {totalRevenue}");

        }
        public static int CalculateOptimalCombo(int coffeeCount, int teaCount, int smoothieCount, double
currentTotal)
        {
            double comboPrice1 = currentTotal;
            double comboPrice2 = currentTotal;
            int comboCount = 0;
            if(coffeeCount==2 && teaCount==1)
            {
                 comboPrice1 = 100000;
            }
            else if(smoothieCount>3)
            {
                 comboPrice2 = currentTotal - 30000;
            } 
            if( comboPrice1 < comboPrice2)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
