using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_5_KeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. khi kế thừa thì lớp con có đầy đủ các phương thức và thuộc tính của lớp cha cho phép
             * 2. khi sử dụng contructor lớp con sẽ vẫn đầy đủ các thuộc tính mà nó được kế thừa
             */
            SinhVien sv1 = new SinhVien();
            sv1.Ten = "Huyền";
            sv1.Sdt = "0564738382";
            sv1.Msv = "ph2345";

            SinhVien sv2 = new SinhVien("văn A","2002","5673849525","25754856954","20-04-2002","avan@gmail.com","hn","ph29348","cntn");

            
        }
    }
}
