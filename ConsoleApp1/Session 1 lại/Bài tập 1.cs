using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập_1_lại
{
    internal class Bài_tập_1
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập chỉ số điện cũ a");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chỉ số điện mới b");
            decimal b = decimal.Parse(Console.ReadLine());
            if( b<a)
            {
                Console.WriteLine("Lỗi:Chỉ số mới phải lớn hoặc bằng chỉ số cũ!");
                return;
            }
            decimal result = b - a;
            Console.WriteLine($"Số điện tiêu thụ là:{result}kWh");
            decimal tienchuathue = 0;
            if (result > 0 && result <= 50)
            {
                tienchuathue = result * 1806m;
            }
            else if (result > 51 && result <= 100)
            {
                tienchuathue  = result * 1806m + ((result-50) * 1866m);
            } 
            else if (result > 101 && result <= 200)
            {
                tienchuathue= 50*1806+50*1866+((result-100) * 2167m);
            }   
            else if (result > 201 && result <= 300)
            {
                tienchuathue = 50 * 1806 + 50 * 1866 +  100 * 2167m+((result-200) * 2.729m);
            }    
            else
            {
                tienchuathue = 50 * 1806 + 50 * 1866 + 100 * 2167m + 100 * 2.729m+((result-300) * 3050m);
            }
            Console.WriteLine($"Tiền chưa thuế là:{tienchuathue:#,##0} VNĐ");
            decimal tiencothue = tienchuathue * 0.08m;
            Console.WriteLine($"Tiền có thuế là:{tiencothue:#,##0} VNĐ");
            decimal tongthanhtoan = tienchuathue + tiencothue;
            Console.WriteLine($"Tổng thanh toán là:{tongthanhtoan:#,##0} VNĐ");

        }
        }
    }
