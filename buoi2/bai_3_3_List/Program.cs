using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_3_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //PHẦN 1: khai báo và khởi tạo
            List<string> lstNames = new List<string>();
            List<sinhvien> lstsinhvien = new List<sinhvien>();//khởi tạo 1 list có kiểu dữ liệu là đối tượng

            //PHẦN 2: thêm phần tử
            lstNames.Add("tên");
            lstNames.Add("c#1");
            lstNames.Add("tên444");
            lstNames.Add("c#4");

            //PHẦN 3: truy xuất giá trị phải index
            Console.WriteLine(lstNames[2]);

            //PHẦN 4: một vài phương thức hay sử dụng
            lstNames.RemoveAt(0);
            lstNames.Clear();
            for (int i = 0; i < lstNames.Count; i++)
            {
                Console.WriteLine(lstNames[i]);
            }

        }
    }
}
