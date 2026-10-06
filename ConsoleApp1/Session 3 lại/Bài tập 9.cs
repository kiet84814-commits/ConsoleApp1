using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_3_lại
{
    internal class Bài_tập_9
    {
        public static double TinhLuyThua(double x, int y)
        {
            double ketqua = 1;
            for(int i=0;i<y;i++)
            {
                ketqua *= x;
            }
            return ketqua;
                
        }
    }
}
