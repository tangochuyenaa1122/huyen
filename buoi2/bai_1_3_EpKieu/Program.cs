using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1_3_EpKieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            string a, b;
            Console.WriteLine("mời bạn nhập số a:");
            a = Console.ReadLine();
            Console.WriteLine("mời bạn nhập số b:");
            b= Console.ReadLine();
            Console.WriteLine($"a + b = { a + b }");

            //CÁCH 1:ép kiểu string về số sử  
            int c = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine($"a + b = {c}");
            //CÁCH 2:ép kiểu với parse
            int d =int.Parse(a) + int.Parse(b);
            Console.WriteLine($"a + b = {d}");
            // Ngoài ra 1 vài VD
            double di = double.Parse("7.9");

            //PHẦN 2: CHUUYEENR ĐỔI KIỂU DỮ LIỆU SỐ VỚI NHAU
            int n1 = 9;
            double n2 = 8.9;
            n2 = n1;
            //n1 = n2 ; kko thể gán dữ liệu vì kích thước double > int
            n1 = (int)n2;

            
        }
    }
}
