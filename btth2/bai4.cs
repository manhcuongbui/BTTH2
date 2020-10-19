using System;
using System.Collections.Generic;
using System.Text;

namespace btth2 // xây dựng một lớp có tên là Dathuc:
    /*n là bậc của đa thức;
     a là mảng một chiều chứa hệ số của đa thức*/
{
    class DaThuc

    {
        private int n;
        private double x;
        private int[] a;
        public DaThuc()
        {
            n = 0;
            a = null;
        }
        public DaThuc(int n)
        {
            this.n = n;
            a = new int[n];
        }
        // phương thức nhập
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập thông tin ĐA THỨC:\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        // phương thức hiện 
        public void Hien()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Thông tin hệ số đa thức:\n");
            for (int i = 0; i < n; i++)
                Console.Write("{0}, ", i);
        }
        // tính tổng hai đa thức
        public DaThuc Tong(DaThuc t2)
        {
            if (this.n == t2.n)
            {
                DaThuc t = new DaThuc(this.n);
                for (int i = 0; i < n; i++)
                    t.a[i] = this.a[i] + t2.a[i];
                return t;
            }
            else return null;
        }
        // tính hiệu hai đa thức
        public DaThuc Hieu(DaThuc t2)
        {
            if (this.n == t2.n)
            {
                DaThuc t = new DaThuc(this.n);
                for (int i = 0; i < n; i++)
                    t.a[i] = this.a[i] - t2.a[i];
                return t;
            }
            else return null;
        }

        class Test
        {
            static void Main4()
            {
                Console.OutputEncoding = Encoding.UTF8;               
                DaThuc t1 = new DaThuc();
                DaThuc t2 = new DaThuc();
                Console.WriteLine("\t\t ĐA THỨC 1:"); t1.Hien();
                Console.WriteLine("\t\t ĐA THỨC 2:"); t2.Hien();
                DaThuc t3 = t1.Tong(t2);// t1+t2
                DaThuc t4 = t1.Hieu(t2);// t1-t2
                Console.WriteLine("\t\t TỔNG 2 ĐA THỨC:"); t3.Hien();
                Console.WriteLine("\t\t HIỆU 2 ĐA THỨC:"); t4.Hien();
                Console.ReadKey();
            }
        }
    }
}



   