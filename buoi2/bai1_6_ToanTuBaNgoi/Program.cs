using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_6_ToanTuBaNgoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string temp = 9 > 8 ? "đúng" : "sai";
            int temp1 = 9 > 8 ? 1 : 0;
            bool temp2 = 9>8?true : false;
            double temp3 = 9 > 8 ? 1.2 : 3.2;
            //Console.WriteLine(temp3);
            int namSinhBT = 2002, gioiTinh = 0;
            int namSinh, GT;
            Console.WriteLine("Mời bạn năm sinh: ");
            namSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập giới tính: ");
            GT = Convert.ToInt32(Console.ReadLine());
            string Goi = (namSinh < namSinhBT && GT == 1) ? "anh" :
                 (namSinh < namSinhBT && GT == 0) ? "chị" :
                 (namSinh < namSinhBT) ? "em" : "bạn";
            Console.WriteLine(Goi);
        }
    }
}
