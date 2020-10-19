using System;
using System.Text;

namespace btth2 /*bài 1:Viết chương trình chuyển một số từ hệ cơ số 10 sang hệ cơ đếm cơ số 16 bằng
cách sử dụng phép toán chia liên tiếp.*/
{
    class Stack
    {
        private int top;
        private int[] s;
        public Stack()
        {
            top = -1;
            s = new int[20];
        }
        public Stack(int n)
        {
            top = -1;
            s = new int[n];
        }
        //
        public bool Full()
        {
            return top == s.Length - 1;
        }
        public bool Empty()
        {
            return top == -1;
        }
        public void Push(int x)
        {
            if (Full()) Console.WriteLine("Stack day");
            else s[++top] = x;
        }
        public int Pop()
        {
            if (Empty()) throw new Exception("Stack rong");
            else
            {
                int x = s[top--];
                return x;
            }
        }
    }
    class Test
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Stack t = new Stack();
            Console.Write("Nhập số nguyên n hệ cơ số 10:"); 
            n = int.Parse(Console.ReadLine());
            // chuyển số nguyên hệ 10 sang hệ 16;
            while (n != 0)
            {
                t.Push(n % 2);
                n = n / 2;
            }
            Console.Write("hệ 16 tương ứng:");
            while (!t.Empty())
                Console.Write(t.Pop());
            Console.ReadKey();
        }
    }
}