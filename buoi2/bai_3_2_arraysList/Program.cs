using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_2_arraysList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //PHẦN 1: khởi tạo và khai báo
            ArrayList arrayLstKoDinhKieu;//khai báo 
            arrayLstKoDinhKieu = new ArrayList();// khởi tạo

            //PHẦN 2: gán giá trị thông qua phương thức add
            arrayLstKoDinhKieu.Add(1);
            arrayLstKoDinhKieu.Add("c#1");
            arrayLstKoDinhKieu.Add(true);
            arrayLstKoDinhKieu.Add('a');
            arrayLstKoDinhKieu.Add(8.5);

            //PHẦN 3: xuất giá trị bắt đầu từ 0
            Console.WriteLine(arrayLstKoDinhKieu[3]);

            for (int i = 0; i < arrayLstKoDinhKieu.Count; i++)
            {
                Console.WriteLine(arrayLstKoDinhKieu[i]);
            }

            //PHẦN 4: một vài phương thức
            arrayLstKoDinhKieu.RemoveAt(0);//xóa tại vị trí chỉ định
            arrayLstKoDinhKieu.Clear();//xóa tất
            
        }
    }
}
