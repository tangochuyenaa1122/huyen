using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1_2NhapXuat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //NHẬP NĂM SINH VÀO VÀ IN RA
            //Bước 1: xác định đc bài cần bao nhiêu biến
            int year;
            //Bước 2: đổ dữ liệu vào các biến nếu cần
            Console.WriteLine("Mời bạn nhập năm: ");
            year = Convert.ToInt32(Console.ReadLine()); // phải ép về đúng kiểu thì mới gán giá trị đc
            //Bước 3: thực thi hoặc xử lý nghiệp vụ
            Console.WriteLine($"Tuổi bạn vừa nhập vào: {2022-year}");
        }
    }
}
