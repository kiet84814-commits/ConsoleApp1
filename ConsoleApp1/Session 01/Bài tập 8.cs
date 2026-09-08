using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_01
{
    internal class Bai_tap_8
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Đây là bài tập 8");
            Console.WriteLine("Nhập Khoảng cách chuyến đi");
            double distance = double.Parse(Console.ReadLine());
            Console.WriteLine("Khoảng cách chuyến đi là: " + distance);
            Console.WriteLine("Nhập mức tiêu thụ nhiên liệu (lít/100km)");
            double fuelConsumption = double.Parse(Console.ReadLine());
            Console.WriteLine("Mức tiêu thụ nhiên liệu là: " + fuelConsumption);
            Console.WriteLine("Nhập giá nhiên liệu (đồng/lít)");
            decimal fuelPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Giá nhiên liệu là: " + fuelPrice);
            Console.WriteLine("Nhập số người đi cùng");
            int numberOfPeople = int.Parse(Console.ReadLine());
            Console.WriteLine("Số người đi cùng là: " + numberOfPeople);
            Console.WriteLine("Nhập quãng đường (km)");
            double quang_duong = double.Parse(Console.ReadLine());
            Console.WriteLine("Quãng đường là: " + quang_duong);
            double tong_so_lit_xang = (quang_duong / 100) * fuelConsumption;
            Console.WriteLine("Tổng số lít xăng tiêu thụ là: " + tong_so_lit_xang);
            decimal tong_chi_phi_xang = (decimal)tong_so_lit_xang * fuelPrice;
            Console.WriteLine("Tổng chi phí xăng là: " + tong_chi_phi_xang);
            decimal chi_phi_moi_nguoi = tong_chi_phi_xang / numberOfPeople;
            Console.WriteLine("Chi phí mỗi người là: " + chi_phi_moi_nguoi);
        }
    }
}
