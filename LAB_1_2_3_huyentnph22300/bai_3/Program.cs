using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Bài 3: Viết 1 chương trình nhập nhiều  thông tin của sinh viên POLY.
            //Mỗi sinh viên khi nhập vào cần các thông tin sau: Tên, Năm Sinh, Msv.
            //Sau khi người dùng nhập xong hết thông tin sinh viên cần thêm thì sẽ
            //in tất cả ra màn hình lưu in thêm tuổi của mỗi sinh viên tương ứng.
            //(Gợi ý mỗi thuộc tính là một mảng)
            int a;
            int i;
            Console.WriteLine("Mời nhập vào số lượng SV: ");
            a = Convert.ToInt32(Console.ReadLine());
            string[] arrNames;
            arrNames = new string[a];
            int[] arrYears;
            arrYears = new int[a];
            string[] arrMaSV;
            arrMaSV = new string[a];
            Console.WriteLine("Mời nhập TT các sinh viên");           
            for (i = 0; i < a ; i++)
            {
                Console.WriteLine($"Thông tin sinh viên {i+1}: ");
                Console.Write("         Họ Ten SV: ");
                arrNames[i] = Console.ReadLine();
                Console.Write("         Năm Sinh: ");
                arrYears[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("         Mã SV: ");
                arrMaSV[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("THÔNG TIN CÁC SINH VIÊN");
            for (i = 0; i < a; i++)
            {
                Console.WriteLine($"Thông tin sinh viên {i + 1}: ");
                Console.WriteLine("         Họ Ten SV: " + arrNames[i]);
                Console.WriteLine("         Năm Sinh: " + arrYears[i]);
                Console.WriteLine("         Mã SV: " + arrMaSV[i]);
                Console.WriteLine("         Tuổi: " + (2022 - arrYears[i]));
            }
        }
    }
}
