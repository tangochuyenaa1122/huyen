using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1_5_cauLenhReNhanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double diemCsharp = 4.9;
            if (diemCsharp >=5)
            {
                Console.WriteLine("Chuc mung ban qua môn");
                return;
            }
            Console.WriteLine("chuc mung ban hoc lai");
            int a;
            Console.WriteLine("Mời bạn nhập điểm: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 9)
            {
                Console.WriteLine("Suất sắc");
            }
            else if (a >= 8)
            {
                Console.WriteLine("giỏi");
            }
            else if (a >= 6)
            {
                Console.WriteLine("Khá");
            }
            else if (a >= 5)
            {
                Console.WriteLine("Trung Bình");
            }
            else Console.WriteLine("Học Lại");

        }
    }
}
