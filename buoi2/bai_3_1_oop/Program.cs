using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_1_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*
             * TRONG LẬP TRÌNH
             * 1. đối tượng : biểu diễn với từ khóa class( Danh từ viết hoa chữ cái đầu)
             * 2. thông tin đối tượng thay thế cách gọi khác là THUỘC TÍNH. 
                  thuộc tính trong lập trình đc biểu diễn dưới dạng khai báo biến
             * 3. hành động đối tượng: đc biểu diễn dưới phương thức method và là động từ
             */
            // PHẦN 1: Tạo Lớp SinhVien sử dụng đối tượng cần biết tên lớp và nơi lưu
            SinhVien sv1;
            sv1 = new SinhVien();
            SinhVien sv2= new SinhVien("quang","ph23765","hn",1,2003,"bk");
            sv1.inRaManHinh();
            sv2.inRaManHinh();
            //PHẦN 2:
            sv1.Ten = "Huyền";
            Console.WriteLine(sv1.Ten);
            SinhVien sv3;
            sv3 = new SinhVien();
            sv3.inRaManHinh();
        }
    }
}
