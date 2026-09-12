using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ConsoleApp1.Session_01.Session_02
{
    internal class Bài_tập_5
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 5");
            Console.WriteLine("Nhập quãng đường di chuyển: ");
            double distance = double.Parse(Console.ReadLine());
            if (distance <= 1 ) {
                decimal fare = 15000;
                Console.WriteLine("Tổng tiền cước taxi là: {0} VNĐ", fare);
            }
            else if (distance <= 10) {
                decimal fare = 15000 + (decimal)(distance - 1) * 12000;
                Console.WriteLine("Tổng tiền cước taxi là: {0} VNĐ", fare);
            }
            else if(distance>=11 && distance <= 30) {
                decimal fare = 15000 + 9 * 12000 + (decimal)(distance - 10) * 10000;
                Console.WriteLine("Tổng tiền cước taxi là: {0} VNĐ", fare);
            }
            else if(distance > 30) {
                decimal total = (15000 + 9 * 12000 + 20 * 10000);
                Console.WriteLine("Tổng tiền cước taxi là: {0} VNĐ", total);
                decimal fare = (total * 0.9m);
                Console.WriteLine("Tổng tiền cước taxi là: {0} VNĐ", fare);
                decimal discount = total - fare;
                Console.WriteLine($"Thành tiền: {fare} VNĐ, giảm giá: {discount} VNĐ");
            }
            
        }
    }
}
