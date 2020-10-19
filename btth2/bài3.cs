using System;
using System.Collections.Generic;
using System.Text;

namespace btth2 // bài 3: Xây dựng lớp Queue;
{
    class Queue
    {
        // Dữ liệu front, rear và mảng một chiều q chứa các phần tử của Queue ;

        private int font;
        private int rear;
        private int[] Q;
        //Khởi tạo Queue bằng cách cho front= rear=0 
        public Queue()
        {
            font = rear = 0;
        }
        public Queue(int n)
        {
            Q = new int[n];
        }

        //Phương thức isEmpty để kiểm tra xem Queue có phần tử nào hay không? 
        public bool isEmpty()
        {
            return font == 0;
        }
        public bool isFull()
        {
            return rear >= Q.Length - 1;
        }
        // Phương thức push để thêm một phần tử vào Queue. 

        public void Push(int n)
        {
            if (isFull()) Console.WriteLine("Queue day");
            else
            {
                rear++;
                Q[rear] = n;
            }
        }
        //Phương thức pop để lấy một phần tử ra khỏi Queue. 

        public int Pop()
        {
            if (isEmpty()) throw new Exception("Queue rong");
            else
            {
                int n = Q[font];
                font--;
                return n;
            }
        }
    }
    class Test
    {
        static void Main4()
        {

        }

    }

}

