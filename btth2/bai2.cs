using System;
using System.Collections.Generic;
using System.Text;

namespace btth2 // bai2: xây dựng lớp PS biểu diễn một phân số;
                // thuộc tính: tử số,mẫu số.
{
    class PS
    {

        // phương thức khởi tạo không tham số, tạo phân số bằng 0,kt nhận 2 số nguyên làm tham số.
        private int ts, ms;
        public PS()
        {
            ts = 0; ms = 1;
        }
        public PS(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }
        public void Nhap()
        {// nhập tử & mẫu
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập tử số :"); ts = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số :"); ms = int.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            if (ms == 1) Console.WriteLine("{0}", ts);
            else Console.WriteLine("{0}/{1}", ts, ms);
        }
        public int Uscln(int x, int y)
        {// "công cụ" tìm UCLN;
            x = Math.Abs(x); y = Math.Abs(y);
            while (x != y)
            {
                if (x > y) x = x - y;
                if (y > x) y = y - x;
            }
            return x;
        }
        public PS Rutgon()
        {
            // chuẩn hóa phân số tối giản.
            int uc = Uscln(this.ts, this.ms);
            this.ts = this.ts / uc;
            this.ms = this.ms / uc;
            return this;
        }
        public PS Tong(PS t2)
        {
            // tổng 2 phân số
            PS t = new PS();
            t.ts = this.ts * t2.ms + this.ms * t2.ts;
            t.ms = this.ms * t2.ms;
            return t.Rutgon();
        }
        public PS hieu(PS t2)
        {
            // tính hiệu
            PS t3 = new PS();
            t3.ts = this.ts * t2.ms - this.ms * t2.ts;
            t3.ms = this.ms * t2.ms;
            return t3.Rutgon();
        }
        public PS tich(PS t2)
        {
            // tính tích hai phân số
            PS t = new PS();
            t.ts = this.ts * t2.ts;
            t.ms = this.ms * t2.ms;
            return t.Rutgon();
        }
        public PS Thuong(PS t2)
        {
            // tìm thương hai phân số
            PS t = new PS();
            t.ts = this.ts * t2.ms;
            t.ms = this.ms * t2.ts;
            return t.Rutgon();
        }

        public static PS operator +(PS t1, PS t2)
        {
            PS t = new PS();
            t.ts = t1.ts * t2.ms + t1.ms * t2.ts;
            t.ms = t1.ms * t2.ms;
            return t.Rutgon();
        }
        public static bool operator >(PS t1, PS t2)
        {
            return t1.ts * t2.ms > t2.ts * t1.ms;
        }
        public static bool operator <(PS t1, PS t2)
        {
            return t1.ts * t2.ms < t2.ts * t1.ms;
        }
    }

    class test
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            PS t1 = new PS(2, 3);
            PS t2 = new PS(5, 3);
            Console.WriteLine("Tổng hai phân số là:");
            PS t = t1.Tong(t2);// Tổng t1+t2;
            t.Hien();
            Console.WriteLine("Hiệu hai phân số là:");
            PS t3 = t1.hieu(t2);// Hiệu t1-t2;
            t.Hien();
            Console.WriteLine(" Tích hai phân số là:");
            PS t4 = t1.tich(t2);// tích t1.t2;
            t.Hien();
            Console.WriteLine(" Thương hai phân số là:");
            PS t5 = t1.Thuong(t2);// thương t1/t2;
            t.Hien();
            if (t1 > t2)
                Console.WriteLine("t1>t2");
            else
                Console.WriteLine("t1<=t2");
            Console.ReadKey();

        }
    }
}



