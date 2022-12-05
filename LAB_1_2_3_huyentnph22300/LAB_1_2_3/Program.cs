using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Bài 0: In bảng cửu chương theo khoảng mà người dùng nhập vào.
            int a, b;
            Console.WriteLine("Bảng cửu chương từ a đến b");
            Console.WriteLine("Mời nhập vào a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời nhập vào b: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a<=b)
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine($"{i} x {j} = {i * j}");
                    }
                }
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine($"{i} x {j} = {i * j}");
                    }
                }
            }
        }
    }
}
