using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_4_Method
{
    internal class Methodvoid
    {
        //PHƯƠNG THỨC KHÔNG TRẢ VỀ KHÔNG THAM SỐ
        public void TinhTong2So()
        {
            int a, b;
            Console.WriteLine("Mời bạn nhập 2 số: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        //PHƯƠNG THỨC KHÔNG TRẢ VỀ CÓ THAM SỐ
        public void TinhTong()
        {
            int a, b;
            Console.WriteLine("Mời bạn nhập 2 số: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        //phương thức trùng tên nhưng khác tham số đc gọi là
        //nạp chồng phương thức(overloading) trong tính đa hình oop
        public void TinhTong(int a, int b)//int a,int b = tham số truyền vào
        {
            //Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine("chưa code xong");
        }
        public void TinhTong(int a, int b, int c)//int a,int b = tham số truyền vào
        {
            Console.WriteLine($"{a} + {b} + {c} = {a + b + c}");
        }
        //LƯU Ý : THAM SỐ CÓ THỂ LÀ NHỮNG KIỂU DỮ KIỆU KHÁC NHAU

        //

    }
}
