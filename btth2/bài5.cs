using System;
using System.Collections.Generic;
using System.Text;

namespace btth2 //bai5:Xây dựng một lớp Date mô tả thông tin về ngày, tháng, năm(month, day, year).
{
    class Date
    {
        private int nam, thang, ngay;
        public void hienthi()
        {
            Console.WriteLine(" Date time: {0}-{1}-{2}", thang, ngay, nam);

        }
        // hàm nextDay() tăng giá trị Date lên từng ngày một;
       /* public void nextDay(int thang, int ngay, int nam)
        {
            int dayofmonth[] = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))
                dayofmonth[2] = 29;

            if (1 <= ngay && ngay < dayOfMonth[thang])
                day++;
            else
                if (day == dayOfMonth[thang])
            {
                day = 1;
                if (thang < 12)
                    thang++;
                else
                    if (thang == 12)
                {
                    thang = 1;
                    nam++;
                }
            }
            
        }*/
        public Date(DateTime dt)
        {
            nam = dt.Year;
            thang = dt.Month;
            ngay = dt.Day;
        } 
    }
    class app
    {
        static void Main5()
        {
            System.DateTime currentTime = System.DateTime.Now;
            Date t1 = new Date(currentTime);
            t1.hienthi();
            Console.ReadKey();


        }
    }
    
}
    