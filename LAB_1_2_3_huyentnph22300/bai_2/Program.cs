using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Bài 2: Viết 1 chương trình cho phép người dùng nhập vào 1 dãy điểm.
            //In ra màn hình dãy điểm người vừa nhập và bệnh cạnh mỗi 1 đầu điều
            //thông báo Trượt hoặt đỗ dựa trên điều kiện điểm đỗ >= 5 và Trượt<5.
            int x;
            int i;
            Console.WriteLine("Mời nhập vào dãy có bao nhiêu điểm: ");
            x = Convert.ToInt32(Console.ReadLine());
            int[] arrDiem;
            arrDiem = new int[x];
            Console.WriteLine("mời nhập dãy điểm:");
            for (i = 0; i < arrDiem.Length; i++)
            {
                arrDiem[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (i = 0; i < arrDiem.Length; i++)
            {
                if (arrDiem[i] <5)
                {
                    Console.WriteLine(arrDiem[i] + " " + "TRƯỢT");
                }
                else
                {
                    Console.WriteLine(arrDiem[i] + " " + "ĐỖ");
                }
            }
        }
    }
}
